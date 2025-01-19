using CarBook.Dto.AuthorDtos;
using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            #region Statistic1
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7170/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.v1 = values.carCount;
            }
            #endregion

            #region Statistic2
            var responseMessage2 = await client.GetAsync("https://localhost:7170/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.v2 = values2.locationCount;
            }
            #endregion

            #region Statistic3
            var responseMessage3 = await client.GetAsync("https://localhost:7170/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.v3 = values3.authorCount;
            }
            #endregion

            #region Statistic4
            var responseMessage4 = await client.GetAsync("https://localhost:7170/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.v4 = values4.blogCount;
            }
            #endregion

            #region Statistic5
            var responseMessage5 = await client.GetAsync("https://localhost:7170/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.v5 = values5.brandCount;
            }
            #endregion

            #region Statistic6
            var responseMessage6 = await client.GetAsync("https://localhost:7170/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.v6 = values6.avgPriceForDaily.ToString("0.00");
            }
            #endregion

            #region Statistic7
            var responseMessage7 = await client.GetAsync("https://localhost:7170/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.v7 = values7.avgRentPriceForWeekly.ToString("0.00");
            }
            #endregion

            #region Statistic8
            var responseMessage8 = await client.GetAsync("https://localhost:7170/api/Statistics/GetAvgRentPriceForMontly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.v8 = values8.avgRentPriceForMontly.ToString("0.00");
            }
            #endregion

            #region Statistic9
            var responseMessage9 = await client.GetAsync("https://localhost:7170/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.v9 = values9.carCountByTransmissionIsAuto;
            }
            #endregion

            #region Statistic10
            var responseMessage10 = await client.GetAsync("https://localhost:7170/api/Statistics/GetBrandNameByMaxCar");
            if (responseMessage10.IsSuccessStatusCode)
            {
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.v10 = values10.brandNameByMaxCar;
            }
            #endregion

            #region Statistic11
            var responseMessage11 = await client.GetAsync("https://localhost:7170/api/Statistics/GetBlogTitleByMaxBlogComment");
            if (responseMessage11.IsSuccessStatusCode)
            {
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.v11 = values11.blogTitleByMaxBlogComment;
            }
            #endregion

            #region Statistic12
            var responseMessage12 = await client.GetAsync("https://localhost:7170/api/Statistics/GetCarCountByKmSmallerThen1000");
            if (responseMessage12.IsSuccessStatusCode)
            {
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.v12 = values12.carCountByKmSmallerThen1000;
            }
            #endregion

            #region Statistic13
            var responseMessage13 = await client.GetAsync("https://localhost:7170/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.v13 = values13.carCountByFuelGasolineOrDiesel;
            }
            #endregion

            #region Statistic14
            var responseMessage14 = await client.GetAsync("https://localhost:7170/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage14.IsSuccessStatusCode)
            {
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.v14 = values14.carCountByFuelElectric;
            }
            #endregion

            #region Statistic15
            var responseMessage15 = await client.GetAsync("https://localhost:7170/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage15.IsSuccessStatusCode)
            {
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.v15 = values15.carBrandAndModelByRentPriceDailyMax;
            }
            #endregion

            #region Statistic16
            var responseMessage16 = await client.GetAsync("https://localhost:7170/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage16.IsSuccessStatusCode)
            {
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16= JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
                ViewBag.v16 = values16.carBrandAndModelByRentPriceDailyMin;
            }
            #endregion

            return View();
        }
    }
}
