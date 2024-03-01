using RestSharp;
using Newtonsoft.Json;
using System.Net;

namespace CatAsService.APIService
{
    internal class ClsCatAsService
    {
        private RestClient Client { get; set; }
        private RestRequest Request { get; set; }
        private RestResponse Response { get; set; }
        private APIKey APIKey { get; set; }

        public ClsCatAsService()
        {
            APIKey = new APIKey(); 
        }

        public RestResponse MethodGET(string client)
        {
                Client = new RestClient(client);
                Request = new RestRequest("", Method.Get);
                return Response = Client.Execute(Request);
        }
        public RestResponse MethodDELETE(string client)
        {
            Client = new RestClient(client);
            Request = new RestRequest("", Method.Delete);
            Request.AddHeader("x-api-key", APIKey.MinhaChaveAPI);
            return Response = Client.Execute(Request);
        }
        public CatModel GetCaracteristicasPorNome(string name)
        {
            var response = MethodGET($"https://api.thecatapi.com/v1/breeds/search?name={name}");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<CatModel> resultados = JsonConvert.DeserializeObject<List<CatModel>>(response.Content.ToString());
                return resultados[0];
            }
            else
                return null;
        }
        public string GetImagemPorImageID(string reference_image_id)
        {
            var response = MethodGET($"https://api.thecatapi.com/v1/images/{reference_image_id}");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                CatImage resultado = JsonConvert.DeserializeObject<CatImage>(response.Content.ToString());
                return resultado.url;
            }
            else
                return null;
        }
        public void FavoritarCat(string reference_image_id)
        {
            var client = new RestClient("https://api.thecatapi.com/v1/favourites");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("x-api-key", APIKey.MinhaChaveAPI);
            request.AddJsonBody(new
            {
                image_id = reference_image_id
            });
            var response = client.Execute(request);
        }
        public void DeletarFavoritoPorNome(string name)
        {
            var response = MethodGET($"https://api.thecatapi.com/v1/favourites?api_key={APIKey.MinhaChaveAPI}");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<FavouriteCat> resultados = JsonConvert.DeserializeObject<List<FavouriteCat>>(response.Content.ToString());
                foreach (var favouriteCat in resultados)
                {
                    response = MethodGET($"https://api.thecatapi.com/v1/images/{favouriteCat.image_id}");

                    CatImage catImage = JsonConvert.DeserializeObject<CatImage>(response.Content.ToString());

                    if (name == catImage.breeds[0].name)
                    {
                        MethodDELETE($"https://api.thecatapi.com/v1/favourites/{favouriteCat.id}");
                        MessageBox.Show($"Raça {name} deletada dos favoritos!");
                    }
                }
            }
        }
        public void DeletarTodosFavoritos()
        {
            var response = MethodGET($"https://api.thecatapi.com/v1/favourites?api_key={APIKey.MinhaChaveAPI}");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<FavouriteCat> resultados = JsonConvert.DeserializeObject<List<FavouriteCat>>(response.Content.ToString());
                foreach (var favouriteCat in resultados)
                {
                    MethodDELETE($"https://api.thecatapi.com/v1/favourites/{favouriteCat.id}");
                }
            }
        }
        public List<string> GetNomesGatosFavoritos()
        {
            List<string> listaNomes = new List<string>();

            var response = MethodGET($"https://api.thecatapi.com/v1/favourites?api_key={APIKey.MinhaChaveAPI}");


            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<FavouriteCat> resultados = JsonConvert.DeserializeObject<List<FavouriteCat>>(response.Content.ToString());
                foreach (var favouriteCat in resultados)
                {
                    response = MethodGET($"https://api.thecatapi.com/v1/images/{favouriteCat.image_id}");

                    CatImage catImage = JsonConvert.DeserializeObject<CatImage>(response.Content.ToString());
                    listaNomes.Add(catImage.breeds[0].name);
                }
            }
            return listaNomes;
        }
    }
}
