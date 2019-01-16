using LogicDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogicDll.SubmitBtnCalculation;

namespace CourseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AccessLbl_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Calculating "Акциз(кВтч)"
            //double summary = Int32.Parse(DaykWTxt.Text) + Int32.Parse(NightkWTxt.Text);
            //string summaryString = Math.Round(summary, 2).ToString();
            //DutyKwphTxt.Text = summaryString;

            //Redirecting values from entry definitions to "Активна енергия Дневна(кВтч)" and "Активна енергия Нощна(кВтч)"
            //DayEnergyKwphTxt.Text = DaykWTxt.Text;
            //NightEnergyKwphTxt.Text = NightkWTxt.Text;

            //Redirecting values from variable("DayPrice") to "Активна енергия Дневна(цена)"
            //double DayPrice = 0.13294;
            //DayEnergyPriceTxt.Text = DayPrice.ToString();

            //Redirecting values from variable("DayPrice") to "Активна енергия Нощна(цена)"
            //double NightPrice = 0.05654;
            //NightEnergyPriceTxt.Text = NightPrice.ToString();

            //Calculating the amount ( in лева ) of used day energy
            //double AmountDay = Int32.Parse(DayEnergyKwphTxt.Text) * DayPrice;
            //string AmountDayString = Math.Round(AmountDay, 2).ToString();
            //DayEnergyAmountTxt.Text = AmountDayString;

            //Calculating the amount ( in лева ) of used night energy
            //double AmountNight = Int32.Parse(NightEnergyKwphTxt.Text) * NightPrice;
            //string AmountNightString = Math.Round(AmountNight, 2).ToString();
            //NightEnergyAmountTxt.Text = AmountNightString;

            //Redirecting values from variable("DutyPrice") to "Акциз(цена)"
            //double DutyPrice = 0.00;
            //DutyPriceTxt.Text = DutyPrice.ToString();

            //Calculating "Акциз( Сума[лв] )"
            //double DutyAmount = DutyPrice * Int32.Parse(DutyKwphTxt.Text);
            //string DutyAmountString = Math.Round(DutyAmount, 2).ToString();
            //DutyAmountTxt.Text = DutyAmountString;

            //Calculating "Снабдяване общо( Сума[лв] )"
            //double AllSupply = Double.Parse(DayEnergyAmountTxt.Text) + Double.Parse(NightEnergyAmountTxt.Text) + Double.Parse(DutyAmountTxt.Text);
            //string AllSupplyString = Math.Round(AllSupply, 2).ToString();
            //AllSupplyTxt.Text = AllSupplyString;

            
            //Getting values from formulas
            var results = SubmitBtnCalculation.Calculate(decimal.Parse(DaykWTxt.Text), decimal.Parse(NightkWTxt.Text));

            //Filling Text boxes with calculated values
            DayEnergyKwphTxt.Text = results.DayEnergyKwphTxt.ToString();
            DayEnergyPriceTxt.Text = results.DayEnergyPriceTxt.ToString();
            DayEnergyAmountTxt.Text = results.DayEnergyAmountTxt.ToString();
            NightEnergyKwphTxt.Text = results.NightEnergyKwphTxt.ToString();
            NightEnergyPriceTxt.Text = results.NightEnergyPriceTxt.ToString();
            NightEnergyAmountTxt.Text = results.NightEnergyAmountTxt.ToString();
            DutyKwphTxt.Text = results.DutyKwphTxt.ToString();
            DutyPriceTxt.Text = results.DutyPriceTxt.ToString();
            DutyAmountTxt.Text = results.DutyAmountTxt.ToString();
            AllSupplyTxt.Text = results.AllSupplyTxt.ToString();
            AccessDNKwphTxt.Text = results.AccessDNKwphTxt.ToString();
            AccessDNPriceTxt.Text = results.AccessDNPriceTxt.ToString();
            AccessDNAmountTxt.Text = results.AccessDNAmountTxt.ToString();
            TransferDNKwphTxt.Text = results.TransferDNKwphTxt.ToString();
            TransferDNPriceTxt.Text = results.TransferDNPriceTxt.ToString();
            TransferDNAmountTxt.Text = results.TransferDNAmountTxt.ToString();
            AccessEGKwphTxt.Text = results.AccessEGKwphTxt.ToString();
            AccessEGPriceTxt.Text = results.AccessEGPriceTxt.ToString();
            AccessEGAmountTxt.Text = results.AccessEGAmountTxt.ToString();
            TransferEGKwphTxt.Text = results.TransferEGKwphTxt.ToString();
            TransferEGPriceTxt.Text = results.TransferEGPriceTxt.ToString();
            TransferEGAmountTxt.Text = results.TransferEGAmountTxt.ToString();
            AllDistributionTxt.Text = results.AllDistributionTxt.ToString();
            PriceMinusVatTxt.Text = results.PriceMinusVatTxt.ToString();
            VatTxt.Text = results.VatTxt.ToString();
            TotalPriceTxt.Text = results.TotalPriceTxt.ToString();
        }

        private void DayEnergyKwphTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
