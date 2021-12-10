using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogLayer
{
    public class Linqconnection
    {
          
        public void add_new_obj(object obj)//string stack_name
        {
            var con = new Context();
            //if (((Stock)obj).GetType().Name.ToString() == "Stock")
            if (obj.GetType().Name.ToString() == "Stock")
            {
                Stock st = (Stock)obj;
                con.Stocks.Add(new Stock { Stock_Name = st.Stock_Name });
            }
            else if (obj.GetType().Name.ToString() == "Catg")
            {
                Catg st = (Catg)obj;
                con.Catgs.Add(new Catg { Catg_Name = st.Catg_Name });
            }
            else if ( obj.GetType().Name.ToString() == "Item")
            {
                Item st = (Item)obj;
                con.Items.Add(new Item {
                    Item_Name = st.Item_Name,Item_Image=st.Item_Image,Item_Catg_ID=st.Item_Catg_ID 
                });
            }
            else if (obj.GetType().Name.ToString() == "StockContainsItems")
            {
                StockContainsItems st = (StockContainsItems)obj;
                con.StockContainsItems.Add(new StockContainsItems
                {
                    Stock_ID = st.Stock_ID,
                    Item_ID = st.Item_ID,
                    Item_Amount = st.Item_Amount
                });
            }

            con.SaveChanges();
        }

        public void SetQeuntityItem(object obj)
        {
            var con = new Context();
            StockContainsItems st = (StockContainsItems)obj;
            StockContainsItems old = con.StockContainsItems.Where(e => e.Item_ID == st.Item_ID).First();

            if (old.Item_Amount - st.Item_Amount > 0)
                old.Item_Amount -= st.Item_Amount;
           
            else if (old.Item_Amount < st.Item_Amount )
            {
                int amount = old.Item_Amount;
                MessageBox.Show($"There is Only left {amount} item out of Stock");
            }

            else if ( old.Item_Amount - st.Item_Amount <= 0 )
            {
                make_delete(old);

                MessageBox.Show("The item out of Stock");
            }
                
            
            con.SaveChanges();

        }

        public IList fill_data_withStock (int num)
        {
            var con = new Context();

            var qeury =( from st in con.StockContainsItems
                        where st.Stock_ID == num
                        select  new { st.Item_ID, st.ItemR.Item_Name, st.Item_Amount } 

                        ).ToList();

                return qeury;
        }
        public IList fill_data_grid_view(string type)
        {
            var con = new Context();  
            if(type== "Stock")// from  Stock page
            {
                return con.Stocks.Select(s => new { s.Stock_ID, s.Stock_Name }).ToList();
            }
            else if (type == "Catg")// from  Catg page
            {
                return con.Catgs.Select(c => new { c.Catg_ID, c.Catg_Name }).ToList();
            }
            else if (type == "Item")// from  Item page
            {
                return con.Items.Select(i => new {
                    i.Item_ID, i.Item_Name,i.Item_Image,i.Item_Catg_ID }).ToList();
            }
            else if (type == "StockContainsItems")// from  StockContainsItems page
            {

                return con.StockContainsItems.Select(i => new {
                    i.Item_ID,
                    i.ItemR.Item_Name,
                    i.Item_Amount
                }).ToList();
               
            }


            return null;
        }
        public void  make_update(object obj)//Stock st
        {
            var con = new Context();
            if ( obj.GetType().Name.ToString()== "Stock") {
                Stock st = (Stock)obj;
                Stock old = con.Stocks.Where(e => e.Stock_ID == st.Stock_ID).First();
                old.Stock_Name = st.Stock_Name;
            }
            else if (obj.GetType().Name.ToString() == "Catg")
            {
                Catg st = (Catg)obj;
                Catg old = con.Catgs.Where(e => e.Catg_ID == st.Catg_ID).First();
                old.Catg_Name = st.Catg_Name;
            }
            else if (obj.GetType().Name.ToString() == "Item")
            {
                Item st = (Item)obj;
                Item old = con.Items.Where(e => e.Item_ID == st.Item_ID).First();
                old.Item_Name = st.Item_Name;
                old.Item_Image = st.Item_Image;
                old.Item_Catg_ID = st.Item_Catg_ID;
            }

            else if (obj.GetType().Name.ToString() == "StockContainsItems")
            {
                StockContainsItems st = (StockContainsItems)obj;
                StockContainsItems old = con.StockContainsItems.Where(e => e.Item_ID == st.Item_ID).First();
                old.Item_Amount = st.Item_Amount;
            }

            con.SaveChanges();
             //return  ( (Stock)obj).GetType().Name.ToString();
        }
        public void make_delete(object obj)
        {
            var con = new Context();
            if ( obj.GetType().Name.ToString() == "Stock")// check if come from Stock page
            {
                Stock st = (Stock)obj;
                Stock old = con.Stocks.Where(e => e.Stock_ID == st.Stock_ID).FirstOrDefault();
                con.Stocks.Remove(old); 
            }
            else if ( obj.GetType().Name.ToString() == "Catg")// check if come from Catg page
            {
                Catg st = (Catg)obj;
                Catg old = con.Catgs.Where(e => e.Catg_ID == st.Catg_ID).FirstOrDefault();
                con.Catgs.Remove(old);
            }
            else if (obj.GetType().Name.ToString() == "Item")// check if come from Item page
            {
                Item st = (Item)obj;
                Item old = con.Items.Where(e => e.Item_ID == st.Item_ID).FirstOrDefault();
                con.Items.Remove(old);
            }
            else if (obj.GetType().Name.ToString() == "StockContainsItems")// check if come from Item page
            {
                StockContainsItems st = (StockContainsItems)obj;
                StockContainsItems old = con.StockContainsItems.Where(e => e.Item_ID == st.Item_ID).FirstOrDefault();
                con.StockContainsItems.Remove(old);
            }

            con.SaveChanges();
        }
    }

}
