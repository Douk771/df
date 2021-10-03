using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace BlazingPizza.Client
{
    public class OrderState
    {
        public bool ShowingConfigureDialog { get; private set; }

        public Project ConfiguringFestival { get; private set; } = new Project();

        public Order Order { get; private set; } = new Order();

        public void ShowConfigurePizzaDialog(Project project)
        {
            ConfiguringFestival = project;
            Order.Project = project;

            ShowingConfigureDialog = true;
        }

        public void CancelConfigurePizzaDialog()
        {
            ConfiguringFestival = null;
            Order.Project = null;
            ShowingConfigureDialog = false;
        }

        public void ConfirmConfigurePizzaDialog()
        {
            Order.Project = ConfiguringFestival;
            ConfiguringFestival = null;

            ShowingConfigureDialog = false;
        }

        public void ResetOrder()
        {
            Order = new Order();
        }

        public void ReplaceOrder(Order order)
        {
            Order = order;
        }
    }
}
