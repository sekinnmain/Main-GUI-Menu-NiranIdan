using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form


    {
        List<Panel> listpanel = new List<Panel>();
        List<Button> listupbutton = new List<Button>();
        int count = 0;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listpanel.Add(ChooseDish_pnl);
            listpanel.Add(EditDish_panel);
            listpanel.Add(Pay_pnl);
            listpanel.Add(feedback_pnl);
            listpanel.Add(end_pnl);
            for (int i = 1; i < 5; i++)
            {
                listpanel[i].Visible = false;
            }
            listpanel[count].Visible = true;

            listupbutton.Add(ChooseDish_btn);
            listupbutton.Add(EditDish_btn);
            listupbutton.Add(Pay_btn);
            listupbutton.Add(FeedBack_btn);
            listupbutton.Add(finish_btn);
            listupbutton[count].Enabled = true;
            for (int i = 1; i < 4; i++)
            {
                listupbutton[i].Enabled = false;
            }
            Previous_Choose_btn.Enabled = false;



        }

        private void Call_Sevice_btn_Click(object sender, EventArgs e)
        {

        }

        private void Next_Choose_btn_Click(object sender, EventArgs e)
        {
            count++;
            listupbutton[count].Enabled = true;
            listupbutton[count - 1].Enabled = false;
            listpanel[count].Visible = true;
            appetizer_tab.Visible = false;
            Previous_Choose_btn.Enabled = true;
            Previous_Pay_btn.Enabled = true;
            NextPreviouscheck();
            ChooseEditMenuCheck();
            EditCheck();


        }

        private void Previous_Choose_btn_Click(object sender, EventArgs e)
        {
            count--;
            listpanel[count].Visible = true;
            listupbutton[count].Enabled = true;
            listpanel[count + 1].Visible = false;/*כל פעם שעובר פאנל פאנל אחד מוצג , ואחד נעלם*/
            listupbutton[count + 1].Enabled = false;/*כל פעם שעובר פאנל כפתור אחד מוצג , ואחד נעלם*/
            NextPreviouscheck();
            ChooseEditMenuCheck();
            EditCheck();





        }

        private void NextPreviouscheck()/*גורמת לכפתור ה"קודם" להיות אפורה בהתחלה, וגורמת לכפתור ה"הבא" להיות בפאנל האחרון אפור*/
        {
            if (count != 0)
            {
                Previous_Choose_btn.Enabled = true;
            }
            else
            {
                Previous_Choose_btn.Enabled = false;
            }
            if (count != 4)
            {
                Next_Choose_btn.Enabled = true;
            }
            else
            {
                Next_Choose_btn.Enabled = false;
            }
        }


        private void ChooseEditMenuCheck()/*בודקת האם הגעת לעריכת מנה או בחירת מנה*/
        {
            if (count == 0 || count == 1)
            {
                listpanel[count].Visible = true;
                appetizer_tab.Visible = true;
            }
        }

        private void EditCheck()
        {
           if ( count == 1 )
            {
                appetizer_tab.Visible = false;
                EditDish_btn.Visible = true;
            }
        }

        private void Drink1_btn_Click(object sender, EventArgs e)
        {
            appetizer_PB.Visible = false;
            appetizer_PB.Image = Image.FromFile("Untitled - 1");
        }

    }
}
