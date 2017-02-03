using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string output;
        
        for (int a = 1; a <= 100; a++)
        {
            _Default generator = new _Default();
            output = generator.getBuckFizz(a);
            TableRow trow = new TableRow();
            TableCell tcell = new TableCell();
            Table1.Rows.Add(trow);
            tcell.Text = output;
            trow.Cells.Add(tcell);

        }
    }
    public string getBuckFizz(int num)
    {
        string output;
        if (num % 3 == 0)
        {
            output = (num % 5 == 0) ? "BuckFizz" : "Fizz";
        }
        else if (num % 5 == 0)
        {
            output = "Buck";
        }
        else
        {
            output = num.ToString();
        }
        return output;
    }
}