﻿namespace courseworkAD1.UI
{
    public class Navigation
    {
        public void homeTab()
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }
        public void productsTab()
        {
            Products products = new Products();
            products.Show();
        }
        public void jobsTab()
        {
            Jobs jobs = new Jobs();
            jobs.Show();
        }

        public void customersTab()
        {
            Customers customers = new Customers();
            customers.Show();
        }

        public void unitsTab()
        {
            Units units = new Units();
            units.Show();
        }

    }
}
