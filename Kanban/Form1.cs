using Kanban.Enums;
using Kanban.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Kanban.Context;

namespace Kanban
{


   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        KanbanDbContext db = new KanbanDbContext();
        People person = new People();
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text != String.Empty)
            {
                person.PersonName = txtIsim.Text;
                if (txtSoyisim.Text!=String.Empty)
                {
                    person.PersonSurname = txtSoyisim.Text;
                    if (txtIsTanimi.Text!=String.Empty)
                    {
                        person.YapilanIs = txtIsTanimi.Text;
                        if (!(rdbToDo.Checked==false&&rdbDoing.Checked==false&&rdbDone.Checked==false))
                        {
                            if (rdbToDo.Checked == true)
                            {
                                person.Status = Status.ToDo;
                            }
                            else if (rdbDoing.Checked == true)
                            {
                                person.Status = Status.Doing;
                            }
                            else if (rdbDone.Checked == true)
                            {
                                person.Status = Status.Done;
                            }
                            db.Peoples.Add(person);
                            db.SaveChanges();
                            var toDoListKisiler = db.Peoples.Where(x => x.Status == Status.ToDo).ToList();
                            var doingListKisiler = db.Peoples.Where(x => x.Status == Status.Doing).ToList();
                            var doneListKisiler = db.Peoples.Where(x => x.Status == Status.Done).ToList();
                            txtIsim.Clear();
                            txtSoyisim.Clear();
                            txtIsTanimi.Clear();
                            rdbDone.Checked = false;
                            rdbDoing.Checked = false;
                            rdbToDo.Checked = false;
                            dataGridView1.DataSource = null;
                            dataGridView2.DataSource = null;
                            dataGridView3.DataSource = null;
                            dataGridView1.DataSource = toDoListKisiler;
                            dataGridView2.DataSource = doingListKisiler;
                            dataGridView3.DataSource = doneListKisiler;
                        }
                        
                        else
                            MessageBox.Show("Lütfen Statü Seçiniz");
                    }
                    else
                        MessageBox.Show("Lütfen İş Tanımı Bilgisi Giriniz");

                }
                else
                    MessageBox.Show("Lütfen Soyisim Bilgisi Giriniz");

            }
            else
                MessageBox.Show("Lütfen İsim Bilgisi Giriniz");
               
            
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var toDoListKisiler = db.Peoples.Where(x => x.Status == Status.ToDo).ToList();
            var doingListKisiler = db.Peoples.Where(x => x.Status == Status.Doing).ToList();
            var doneListKisiler = db.Peoples.Where(x => x.Status == Status.Done).ToList();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView1.DataSource = toDoListKisiler;
            dataGridView2.DataSource = doingListKisiler;
            dataGridView3.DataSource = doneListKisiler;
        }
        int idTakip ;


        private void btnDoingEkle_Click(object sender, EventArgs e)
        {
            idTakip = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            var secilenKisi = db.Peoples.Where(x => x.PersonId == idTakip).FirstOrDefault();
            secilenKisi.Status = Status.Doing;
            db.SaveChanges();
            var toDoListKisiler = db.Peoples.Where(x => x.Status == Status.ToDo).ToList();
            var doingListKisiler = db.Peoples.Where(x => x.Status == Status.Doing).ToList();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = toDoListKisiler;
            dataGridView2.DataSource = doingListKisiler;
        }

        private void btnDoneEkle1_Click(object sender, EventArgs e)
        {
            idTakip = idTakip = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            var secilenKisi = db.Peoples.Where(x => x.PersonId == idTakip).FirstOrDefault();
            secilenKisi.Status = Status.Done;
            db.SaveChanges();
            var toDoListKisiler = db.Peoples.Where(x => x.Status == Status.ToDo).ToList();
            var doneListKisiler = db.Peoples.Where(x => x.Status == Status.Done).ToList();
            dataGridView1.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView1.DataSource = toDoListKisiler;
            dataGridView3.DataSource = doneListKisiler;
        }

        private void btnDoneEkle2_Click(object sender, EventArgs e)
        {
            idTakip = idTakip = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            
            var secilenKisi = db.Peoples.Where(x => x.PersonId == idTakip).FirstOrDefault();
            secilenKisi.Status = Status.Done;
            db.SaveChanges();
            var doingListKisiler = db.Peoples.Where(x => x.Status == Status.Doing).ToList();
            var doneListKisiler = db.Peoples.Where(x => x.Status == Status.Done).ToList();
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView2.DataSource = doingListKisiler;
            dataGridView3.DataSource = doneListKisiler;
        }
    }
}
