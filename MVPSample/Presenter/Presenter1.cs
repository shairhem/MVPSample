using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPSample.Model;

namespace MVPSample.Presenter
{
    public class Presenter1
    {
        private Model1 model;
        private MainView view;

        public Presenter1(Model1 model, MainView view)
        {
            this.model = model;
            this.view = view;

            view.presenter = this;
        }

        public void onOperand1Changed(int operand1)
        {
            model.operand1 = operand1;
        }

        public void onOperand2Changed(int operand2)
        {
            model.operand1 = operand2;
        }

        public void onClick()
        {
            model.add();
                
            updateView();
        }

        private void updateView()
        {
            view.updateView(model.operand1,model.operand2,model.result);
        }
    }
}
