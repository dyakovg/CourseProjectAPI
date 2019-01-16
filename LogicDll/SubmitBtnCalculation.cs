using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicDll
{
    public class SubmitBtnCalculation
    {
            public float DayEnergyKwphTxt { get; set; }
            public float DayEnergyPriceTxt { get; set; }
            public float DayEnergyAmountTxt { get; set; }
            public float NightEnergyKwphTxt { get; set; }
            public float NightEnergyPriceTxt { get; set; }
            public float NightEnergyAmountTxt { get; set; }
            public float DutyKwphTxt { get; set; }
            public float DutyPriceTxt { get; set; }
            public float DutyAmountTxt { get; set; }
            public float AllSupplyTxt { get; set; }
            public float AccessDNKwphTxt { get; set; }
            public float AccessDNPriceTxt { get; set; }
            public float AccessDNAmountTxt { get; set; }
            public float TransferDNKwphTxt { get; set; }
            public float TransferDNPriceTxt { get; set; }
            public float TransferDNAmountTxt { get; set; }
            public float AccessEGKwphTxt { get; set; }
            public float AccessEGPriceTxt { get; set; }
            public float AccessEGAmountTxt { get; set; }
            public float TransferEGKwphTxt { get; set; }
            public float TransferEGPriceTxt { get; set; }
            public float TransferEGAmountTxt { get; set; }
            public float AllDistributionTxt { get; set; }
            public float PriceMinusVatTxt { get; set; }
            public float VatTxt { get; set; }
            public float TotalPriceTxt { get; set; }

            public static SubmitBtnCalculation Calculate(decimal DaykWTxt, decimal NightkWTxt)
            {

            SubmitBtnCalculation results = new SubmitBtnCalculation();

            //Redirecting values from entry definitions to " Активна енергия Дневна(кВтч) " and " Активна енергия Нощна(кВтч) "
            results.DayEnergyKwphTxt = (float)DaykWTxt;
            results.NightEnergyKwphTxt = (float)NightkWTxt;
            
            // Calculating "Акциз(кВтч)"
            float preSummary = (float)DaykWTxt + (float)NightkWTxt;
            double summary = Math.Round(preSummary, 4);
            results.DutyKwphTxt = (float)summary;

            //Redirecting values from variable(" DayPrice ") to "Активна енергия Дневна(цена)"
            double DayPrice = 0.13294;
            results.DayEnergyPriceTxt = (float)DayPrice;

            //Redirecting values from variable(" DayPrice ") to "Активна енергия Нощна(цена)"
            double NightPrice = 0.05654;
            results.NightEnergyPriceTxt = (float)NightPrice;

            //Calculating the amount ( in лева ) of used day energy
            double preAmountDay = results.DayEnergyKwphTxt * (float)DayPrice;
            double AmountDay = Math.Round(preAmountDay, 2);
            results.DayEnergyAmountTxt = (float)AmountDay;

            //Calculating the amount ( in лева ) of used night energy
            double preAmountNight = results.NightEnergyKwphTxt * (float)NightPrice;
            double AmountNight = Math.Round(preAmountNight, 2);
            results.NightEnergyAmountTxt = (float)AmountNight;

            //Redirecting values from variable(" DutyPrice ") to " Акциз(цена) "
            double DutyPrice = 0.00;
            results.DutyPriceTxt = (float)DutyPrice;

            //Calculating "Акциз( Сума[лв] )"
            double preDutyAmount = DutyPrice * (results.DutyKwphTxt);
            double DutyAmount = Math.Round(preDutyAmount, 2);
            results.DutyAmountTxt = (float)DutyAmount;

            //Calculating " Снабдяване общо( Сума[лв] ) "
            double preAllSupply = results.DayEnergyAmountTxt + results.NightEnergyAmountTxt + results.DutyAmountTxt;
            double AllSupply = Math.Round(preAllSupply, 2);
            results.AllSupplyTxt = (float)AllSupply;

            //Redirecting value from "Акциз ( квтч ) " to " Достъп до р. мрежа( квтч ) "
            results.AccessDNKwphTxt = results.DutyKwphTxt;

            //Redirecting value from "Акциз ( квтч ) " to " Пренос през р. мрежа( квтч ) "
            results.TransferDNKwphTxt = results.DutyKwphTxt;

            //Redirecting value from "Акциз ( квтч ) " to " Достъп до е. мрежа ( квтч ) "
            results.AccessEGKwphTxt = results.DutyKwphTxt;

            //Redirecting value from "Акциз ( квтч ) " to " Пренос през е.мрежа ( квтч ) "
            results.TransferEGKwphTxt = results.DutyKwphTxt;

            //Redirecting values from variable(" AccessDNKwphPrice ") to " Достъп до р. мрежа ( цена ) "
            double AccessDNKwphPrice = 0.00519;
            results.AccessDNPriceTxt = (float)AccessDNKwphPrice;

            //Redirecting values from variable(" TransferDNKwphPrice ") to " Пренос през р. мрежа ( цена ) "
            double TransferDNKwphPrice = 0.03245;
            results.TransferDNPriceTxt = (float)TransferDNKwphPrice;

            //Redirecting values from variable(" AccessEGKwphPrice ") to " Достъп до е. мрежа ( цена ) "
            double AccessEGKwpPrice = 0.00139;
            results.AccessEGPriceTxt = (float)AccessEGKwpPrice;

            //Redirecting values from variable(" TransferEGKwphPrice ") to " Пренос през е.мрежа ( цена ) "
            double TransferEGKwphPrice = 0.00845;
            results.TransferEGPriceTxt = (float)TransferEGKwphPrice;

            //Calculating " Достъп до р. мрежа (Сума [лв]) "
            double preAccessDNAmount = results.AccessDNKwphTxt * results.AccessDNPriceTxt;
            double AccessDNAmount = Math.Round(preAccessDNAmount, 2);
            results.AccessDNAmountTxt = (float)AccessDNAmount;

            //Calculating " Пренос през р. мрежа (Сума [лв]) "
            double preTransferDNAmount = results.TransferDNKwphTxt * results.TransferDNPriceTxt;
            double TransferDNAmount = Math.Round(preTransferDNAmount, 2);
            results.TransferDNAmountTxt = (float)TransferDNAmount;

            //Calculating " Достъп до е. мрежа (Сума [лв]) "
            double preAccessEGAmount = results.AccessEGPriceTxt * results.AccessEGKwphTxt;
            double AccessEGAmount = Math.Round(preAccessEGAmount, 2);
            results.AccessEGAmountTxt = (float)AccessEGAmount;

            //Calculating " Пренос през е.мрежа (Сума [лв]) "
            double preTransferEGAmount = results.TransferEGKwphTxt * results.TransferEGPriceTxt;
            double TransferEGAmount = Math.Round(preTransferEGAmount, 2);
            results.TransferEGAmountTxt = (float)TransferEGAmount;

            //Calculating " Разпределение - общо ( Сума[лв] ) "
            double preAllDistribution = results.AccessDNAmountTxt + results.TransferDNAmountTxt + results.AccessEGAmountTxt + results.TransferEGAmountTxt;
            double AllDistribution = Math.Round(preAllDistribution, 2);
            results.AllDistributionTxt = (float)AllDistribution;

            //Calculating Price with VAT
            double prePrice = results.AllSupplyTxt + results.AllDistributionTxt;
            double Price = Math.Round(prePrice, 2);
            results.PriceMinusVatTxt = (float)Price;

            //Calculating Total Price
            double prePriceWithVat = results.PriceMinusVatTxt * 1.2;
            double PriceWithVat = Math.Round(prePriceWithVat, 2);
            results.TotalPriceTxt = (float)PriceWithVat;

            //Calculating VAT
            double preVat = results.PriceMinusVatTxt / 5;
            double Vat = Math.Round(preVat, 2);
            results.VatTxt = (float)Vat;

            

            return results;
            
            }


    }
}
