using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram243.p.rapidapi.com/userinfo/canberkyangazz"),
                Headers =
                 {
                       { "x-rapidapi-key", "39b51660efmsh55284f5e4b23fa0p1cd5b9jsn72b10c921148" },
                       { "x-rapidapi-host", "instagram243.p.rapidapi.com" },
                 },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body)!;
                ViewBag.v1 = resultInstagramFollowersDtos.follower_count;
                ViewBag.v2 = resultInstagramFollowersDtos.following_count;

            }

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=murattyucedag"),
                Headers =
                 {
                     { "x-rapidapi-key", "39b51660efmsh55284f5e4b23fa0p1cd5b9jsn72b10c921148" },
                     { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
                 },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwittterFollowersDto resultTwittterFollowersDto = JsonConvert.DeserializeObject<ResultTwittterFollowersDto>(body2)!;
                ViewBag.v3 = resultTwittterFollowersDto.data?.user_info?.followers_count;
                ViewBag.v4 = resultTwittterFollowersDto.data?.user_info?.friends_count;
            }

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmurat-y%C3%BCceda%C4%9F-186933149%2F"),
                Headers =
                 {
                     { "x-rapidapi-key", "39b51660efmsh55284f5e4b23fa0p1cd5b9jsn72b10c921148" },
                     { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
                },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedinFollowersDto resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3)!;
                ViewBag.v5 = resultLinkedinFollowersDto.data?.followers_count;
            }


            return View();
        }
    }
}

