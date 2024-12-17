# Calculator

by Jessadaruk Wichachai, 673450207-3, Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

```
private void button1_Click(object sender, EventArgs e)
{
    // ข้อความตัวอักษร
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert string to number (integer)
    double iNum1 = double.Parse(inputNum1);
    double iNum2 = double.Parse(inputNum2);
    // double ทำให้เราสามารถทำการ + - * / เป็นทศนิยมได้
    double iResult = iNum1 + iNum2;
    // ที่ตัวแปรชื่อ result
    // มีคุณสมบัติชื่อ Text
    result.Text = iResult.ToString();
}
```

### รับข้อมูล

ตัวอย่าง

``` ดีงข้อมูลจากช่องป้อนข้อความที่ชือ num1 และเก็บไว้ในตัวแปร inputNum1 ดีงข้อมูลจากช่องป้อนข้อความที่ชือ num2 และเก็บไว้ในตัวแปร inputNum2
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
``` 

### แปลงชนิดของข้อมูล

ตัวอย่าง

``` แปลงข้อมูลจาก String เป็น double เพื่อที่จะสามารถ + - * / เป็นทศนิยมได้
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    double iNum1 = double.Parse(inputNum1);
    double iNum2 = double.Parse(inputNum2);
```

### คำนวนผลลัพท์

ตัวอย่าง

``` คำนวณจากตัวแปร iNum1 + iNum2 แล้วหาผลลัพธ์
    double iResult = iNum1 + iNum2;
```

### แสดงผล

ตัวอย่าง

``` แปลค่ากลับไปเป็น String แล้วแสดงผลทางช่องที่ชื่อ result
    result.Text = iResult.ToString();
```

## ปุ่มลบ
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    double iNum1 = double.Parse(inputNum1);
    double iNum2 = double.Parse(inputNum2);
    double iResult = iNum1 - iNum2;
    result.Text = iResult.ToString();

## ปุ่มคูณ
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    double iNum1 = double.Parse(inputNum1);
    double iNum2 = double.Parse(inputNum2);
    double iResult = iNum1 * iNum2;
    result.Text = iResult.ToString();
## ปุ่มหาร
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    double iNum1 = double.Parse(inputNum1);
    double iNum2 = double.Parse(inputNum2);
    double iResult = iNum1 / iNum2;
    result.Text = iResult.ToString();
## ปุ่มลบข้อมูล
    result.Clear();
    num1.Clear();
    num2.Clear();

