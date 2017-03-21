using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldofShapes
{
    class CircleStrategy : StrategyInterface
    {
         CircleStrategy(WorldOfShapes Foreground) {
        this.form = Foreground;
    }
    public void ShowOptions() {
        // caller should hide all options first
        this.form.Instruction1.Visible = false;
                    submit1.Visible = false;
                    inputBox.Visible = false;
                    Instruction2.Visible = true;
                    data.Visible = true;
                    Enter.Visible = true;
       this.Form.txtRadius.Visible = True;
    }
    Public void GatherInput() {
         this.radius = txtRadius.Text;
    }
    Public void ValidateInput() {
        // some check if the input is bad, throw exception
       // or can return boolean and act accordingly (caller)
    }
    Public void ProcessInput() {
       // do stuff on the form
    }

    
public  WorldOfShapes circle { get; set; }
public  WorldOfShapes form { get; set; }}
}
