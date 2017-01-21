using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //LabelWeight.Visible = false;
        //TextBoxWeight.Visible = false;
        //LabelLength.Visible = false;
        //TextBoxLength.Visible = false;
        //LabelHeight.Visible = false;
        //TextBoxHeight.Visible = false;
        //LabelWidth.Visible = false;
        //TextBoxWidth.Visible = false;
      
    }

    protected void DropDownListAirLand_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownListAirLand.SelectedIndex == 0)
        {
            LabelWeight.Visible = false;
            TextBoxWeight.Visible = false;
            LabelLength.Visible = false;
            TextBoxLength.Visible = false;
            LabelHeight.Visible = false;
            TextBoxHeight.Visible = false;
            LabelWidth.Visible = false;
            TextBoxWidth.Visible = false;
            LabelCost.Visible = false;
            LabelDuration.Visible = false;
        }
        if (DropDownListAirLand.SelectedIndex == 2)
        {
            LabelWeight.Visible = true;
            TextBoxWeight.Visible = true;
            LabelLength.Visible = false;
            TextBoxLength.Visible = false;
            LabelHeight.Visible = false;
            TextBoxHeight.Visible = false;
            LabelWidth.Visible = false;
            TextBoxWidth.Visible = false;
            LabelCost.Visible = false;
            LabelDuration.Visible = false;
        }
        if (DropDownListAirLand.SelectedIndex == 1)
        {
            LabelWeight.Visible = false;
            TextBoxWeight.Visible = false;
            LabelLength.Visible = true;
            TextBoxLength.Visible = true;
            LabelHeight.Visible = true;
            TextBoxHeight.Visible = true;
            LabelWidth.Visible = true;
            TextBoxWidth.Visible = true;
            LabelCost.Visible = false;
            LabelDuration.Visible = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        LabelCost.Visible = true;
        int firstCity = DropDownList1st.SelectedIndex;
        int secondCity = DropDownList2nd.SelectedIndex;
        double airLand = DropDownListAirLand.SelectedIndex;
        double weight = Convert.ToInt32(TextBoxWeight.Text);
        double height = Convert.ToInt32(TextBoxHeight.Text);
        double width = Convert.ToInt32(TextBoxWidth.Text);
        double length = Convert.ToInt32(TextBoxLength.Text);

        int[,] distance;
        
        distance = new int[10, 10] {
            { 1, 214, 396, 4443, 4466, 10553, 3459, 5437, 3547, 331 },
            {214, 1, 572, 6841, 7005, 16950, 3627, 5642, 3726, 316 },
            {396, 572, 1, 3990, 4076, 10236, 3852, 5777, 3933, 274 },
            {4443, 6841, 3990, 1, 1202, 7483, 6836, 8315, 6875, 4242 },
            {4466, 7005, 4076, 1202, 1, 6307, 7786, 8688, 7755, 4256 },
            {10553, 16950, 10236, 7483, 6307, 1, 9926, 7497, 9667, 10335 },
            {3459, 3627, 3852, 6836, 7786, 9929, 1, 2789, 491, 3642 },
            {5437, 5642, 5777, 8315, 8688, 7497, 2789, 1, 2518, 5551 },
            {3547, 3726, 3933, 6875, 7755, 9667, 491, 2518, 1, 3714 },
            {331, 316, 274, 4242, 4256, 10335, 3642, 5551, 3714, 1 }
        };

        int userDistance = distance[firstCity, secondCity];
        double typeOfTrans = DropDownListAirLand.SelectedIndex;
        double dimensions = (height * width * length) / 10000; //to Square meters
        double factorLand = 0;
        double factorAir = (weight * (userDistance / 2)) / 1000;
        //////////
        if (typeOfTrans == 1)
        {
            if (dimensions > 100)
            {
                factorLand = 1000;
                LabelCost.Text = "Parcel is too big!";
            }
            else if (dimensions <= 100)
            {
                factorLand = (userDistance * dimensions) / 1000;
                if (factorLand < 10)
                {
                    factorLand = 10;
                }
                LabelCost.Text = (Math.Round(factorLand, 2)).ToString() + " £";
            }
        }
        if (typeOfTrans == 2)
        {
            if (weight > 100)
            {
                LabelCost.Text = "Parcel is too heavy.";
            }
            else
            {
                if (factorAir > 100)
                {
                    factorAir = 100;
                }
                else if (factorAir < 10)
                {
                    factorAir = 20;
                }
                LabelCost.Text = (Math.Round(factorAir, 2)).ToString() + " £";
            }
        }



    }




    protected void Button2_Click(object sender, EventArgs e)
    {
        LabelDuration.Visible = true;
        int firstCity = DropDownList1st.SelectedIndex;
        int secondCity = DropDownList2nd.SelectedIndex;
        double airLand = DropDownListAirLand.SelectedIndex;
        double weight = Convert.ToInt32(TextBoxWeight.Text);
        double height = Convert.ToInt32(TextBoxHeight.Text);
        double width = Convert.ToInt32(TextBoxWidth.Text);
        double length = Convert.ToInt32(TextBoxLength.Text);
        int days = 0;
        int[,] distance;
        
        distance = new int[10, 10] { { 1, 214, 396, 4443, 4466, 10553, 3459, 5437, 3547, 331 },
            {214, 1, 572, 6841, 7005, 16950, 3627, 5642, 3726, 316 },
            {396, 572, 1, 3990, 4076, 10236, 3852, 5777, 3933, 274 },
            {4443, 6841, 3990, 1, 1202, 7483, 6836, 8315, 6875, 4242 },
            {4466, 7005, 4076, 1202, 1, 6307, 7786, 8688, 7755, 4256 },
            {10553, 16950, 10236, 7483, 6307, 1, 9926, 7497, 9667, 10335 },
            {3459, 3627, 3852, 6836, 7786, 9929, 1, 2789, 491, 3642 },
            {5437, 5642, 5777, 8315, 8688, 7497, 2789, 1, 2518, 5551 },
            {3547, 3726, 3933, 6875, 7755, 9667, 491, 2518, 1, 3714 },
            {331, 316, 274, 4242, 4256, 10335, 3642, 5551, 3714, 1 }
        };

        int userDistance = distance[firstCity, secondCity];
        double typeOfTrans = DropDownListAirLand.SelectedIndex;



        if (typeOfTrans == 1)
        {
            LabelDuration.Text = (userDistance / 100).ToString() + " Days";
        }
        if (typeOfTrans == 2)
        {
            if (userDistance <= 1000)
            {
                days = (userDistance / 150) + 2;
            }
            else if (userDistance <= 4000)
            {
                days = (userDistance / 250) + 2;
            }
            else
            {
                days = 20;
            }
            LabelDuration.Text = (days).ToString() + " Days";
        }
    }



    protected void DropDownList1st_SelectedIndexChanged(object sender, EventArgs e)
    {
        LabelCost.Visible = false;
        LabelDuration.Visible = false;
    }

    protected void DropDownList2nd_SelectedIndexChanged(object sender, EventArgs e)
    {
        LabelCost.Visible = false;
        LabelDuration.Visible = false;
    }
}