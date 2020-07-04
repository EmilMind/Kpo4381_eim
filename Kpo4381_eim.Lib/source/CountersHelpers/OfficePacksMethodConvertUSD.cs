using Kpo4381.eim.Lib.source.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Kpo4381.eim.Lib
{
    public static class OfficePacksMethodConvertUSD
    {
        /*  Данный метод необходим для конвертиции стоимости программных решений в валюте
            Метод должен обрашаться к API для получения актуального курса валют и преобразовывать стоимость согласно полученному курсу 
        */

        //Для каждого элемента массива проводим конвертицию стоимости в доллар
        public static List<OfficePacks> ConvertPricesToUsd(List<OfficePacks> packs)
        {
            double rate = 0d;
            try
            {
                 rate = GetRUBUSDRate();
            }
            catch(BrokenApiException ex)
            {
                throw ex;
            }
            
            foreach (OfficePacks pack in packs)
            {
                pack.price = (int)Math.Floor(pack.price * rate);
            }
            return packs;
        }
        //Для каждого элемента массива проводим конвертицию стоимости в рубли
        public static List<OfficePacks> ConvertPricesToRub(List<OfficePacks> packs)
        {
            double rate = 0d;
            try
            {
                rate = GetUSDRUBRate();
            }
            catch (BrokenApiException ex)
            {
                throw ex;
            }

            foreach (OfficePacks pack in packs)
            {
                pack.price = (int)Math.Floor(pack.price * rate);
            }
            return packs;
        }

        //Получение курса рубль-доллар с API
        public static double GetRUBUSDRate()
        {
            double rate = 1d;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync("https://currate.ru/api/?get=rates&pairs=USDRUB,RUBUSD&key=fc1e750a9df453499655ac3440820904").Result;
                    if (response != null)
                    {
                        string jsonString = response.Content.ReadAsStringAsync().Result;
                        var usd = (JObject)JsonConvert.DeserializeObject(jsonString);
                        rate = Convert.ToDouble(usd.SelectToken("data.RUBUSD"));
                    }
                    else
                        throw new BrokenApiException();
                }
            }
            catch
            {
                throw new BrokenApiException();
            }
            return rate;
        }
        // Получение курса доллар=рубль с API
        public static double GetUSDRUBRate()
        {
            double rate = 1d;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync("https://currate.ru/api/?get=rates&pairs=USDRUB,RUBUSD&key=fc1e750a9df453499655ac3440820904").Result;
                    if (response != null)
                    {
                        string jsonString = response.Content.ReadAsStringAsync().Result;
                        var usd = (JObject)JsonConvert.DeserializeObject(jsonString);
                        rate = Convert.ToDouble(usd.SelectToken("data.USDRUB"));
                    }
                    else
                        throw new BrokenApiException();
                }
            }
            catch
            {
                throw new BrokenApiException();
            }
            return rate;
        }
    }
}
