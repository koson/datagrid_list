using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_List
{
    public partial class Form1 : Form
    {
        // 2. สร้างพื้นที่เก็บข้อมูล ในที่นี้สร้างเป็น List เพราะสามารถเพิ่มได้ไม่จำกัด

        List<Items> goods = new List<Items>(); // goods เป็นรายการสินค้า ที่เพิ่มได้เรื่อยๆ

        public Form1()
        {
            InitializeComponent();
            // 3. สร้างสินค้าและเพิ่มในรายการ List
            Items g1 = new Items();
            g1.code = "0001";
            g1.name = "Samsung E5";
            g1.price = 20000;
            // 3.1 เพิ่มสินค้าเข้าสู่ List
            goods.Add(g1);

            // 3.2 สร้างสินค้าอีกหนึ่งรายการ
            Items g2 = new Items();
            g2.code = "0002";
            g2.name = "IPhone I6";
            g2.price = 30000;
            // 3.3 เพิ่มสินค้าเข้าสู่ List
            goods.Add(g2);

            // 3.4 สร้างสินค้าอีกหนึ่งรายการ
            Items g3 = new Items();
            g3.code = "0003";
            g3.name = "OPPO";
            g3.price = 15000;
            // 3.5 เพิ่มสินค้าเข้าสู่ List
            goods.Add(g3);

            // ถึงตรงนี้จะมีรายการสินค้าใน List<items> ที่ชื่อ goods อยู่ทั้งสิ้น 2 รายการ
            // ตั้ง break point ที่ปีกกาปิด แล้วกด RUN เพื่อดูว่าถูกต้องหรือไม่
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // เมื่อ double click ที่ button1 แล้ว visual studio จะพาเรามาที่นี่
            // ให้เพิ่ม code เพื่อนำ List ไปแสดงใน DatagridView1
            
            // 4. เพิ่ม code สำหรับนำ List ไปแสดงใน DatagridView1
            dataGridView1.DataSource = goods;
            // จากนั้นกด RUN เพื่อดูผลงาน
            //------------------------------ ผลปรากฏว่า ไม่มีอะไรปรากฏใน Datagridview1 เลย
            // เพราะว่า datagridview1 จะแสดงผลเฉพาะส่วนที่เป็น properties 
            // ดังนั้น เราต้องไปแก้ไขคลาส Items ให้มีส่วนของ propeeries

        }
    }

    // 1. สร้างคลาสสำหรับรายการสินค้า
    class Items
    {
        public string code = string.Empty;
        public string name = string.Empty;
        public double price = 0.0;
        // สมมติว่ามีแค่นี้ก่อน

        // 5. เพื่อให้ List แสดงใน datagrid ต้องสร้าง properties ในคลาสนี้

        //public string Code { get; set; }  // คนละตัวกับ code ข้างบน อันนี้ขึ้นต้นด้วยพิมพ์ใหญ่
        //public string Name { get; set; }
        //public double Price { get; set; }

        // 5.1 ทดลองรันดูซิ
        // พบว่ามีการนำ items ไปแสดงบน datagridview แล้ว แต่ยังไม่ถูกต้อง ต้องแก้ไข properties
        public string Code { get { return code; } }  // property ตัวนี้มีฟังก์ชัน get อย่างเดียว เพราะไม่ต้องการให้รับค่าใดๆ
        public string Name { get { return name; } }   // เว้นเสียแต่ต้องการให้แก้ไขได้โดยผู้ใช้จาก datagridview 
        public double Price { get { return price; } }  // ซึ่งค่อยว่ากันอีกที
        // 5.2 ลอง RUN ดูอีกที

    }
}
            // จบเพียงแค่นี้ ขอบคุณที่ติดตามชม ไว้พบกันในโอกาสหน้าครับ
