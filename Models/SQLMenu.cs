using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class SQLMenu: RestaurantMenu
    {
        private AppDbContext context;

        public SQLMenu(AppDbContext context)
        {
            this.context = context;

        }

        public MenuItem Add(MenuItem menuitem)
        {
            context.Menu.Add(menuitem);
            context.SaveChanges();
            return menuitem;
        }

        public MenuItem Delete(int id)
        {
            MenuItem menuitem = context.Menu.Find(id);
            if (menuitem != null)
            {
                context.Menu.Remove(menuitem);
                context.SaveChanges();
            }
            return menuitem;
        }

        public List <MenuItem> GetMenu(int id)
        {
            var menu = context.Menu.ToList();

            List<MenuItem> newmenu = new List<MenuItem>();
         
            foreach (var item in menu)
            {
               // if(item.RId==4)
               // {
                 //   newmenu.Add(item);

                //}
            }

            return newmenu;

        }

        public MenuItem Getitem(int id)
        {
            return context.Menu.Find(id);
        }

        public MenuItem Update(MenuItem Menuchanges)
        {
            var menu  = context.Menu.Attach(Menuchanges);
            menu.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Menuchanges;

        }
    }
}
