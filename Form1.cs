using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        enum Operators { None,Add,Substract,Multiply,Divide,Result} //호출
       
        Operators currentOperator = Operators.None; //열거형 선언 및 변수 선언 / 데이터 형(int double 등)과 같이 동작
        //처음은 아무것도 선택 안 되어 있으므로 None
        Boolean operatorChageFlag = false; //연산자 버튼 눌리면 기존 입력 숫자는 저장/ 새로 받을 숫자에 대한 변수로 사용

        //피연산자
        double firstOperand;
        double secondOperand;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            // 입력하는 숫자를 구분해야! -> 다 뒤로 덧붙여지고 있음.
            //연산자 전후를 분리해서 저장해야 하며(연산자 선택되었음을 알 수 있어야 함)
            // 연산자 누른 후 새로 입력할 숫자를 위해 레이블에 출력된 숫자를 지우는 작업도 필요

            if (operatorChageFlag == true) //연산자가 눌렸는지 눌리면 true임
            {
                label1.Text = ""; //기존 문자 삭제
                operatorChageFlag = false; //다시 지우는 것을 방지하기 위해 false로
            }
            string strnumber = label1.Text += "1"; //레이블 초기값이 0인 문자열
            //01로 저장되어 int.Parse에 의해 1로 변환
            double intnumber = double.Parse(strnumber); //문자열을 숫자로 변환
            label1.Text = intnumber.ToString(); //다시 문자열로 변환해서 출력
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChageFlag==true)
            {
                label1.Text = "";
                operatorChageFlag = false;
            }
            string strnumber = label1.Text += "2";
            double intnumber = double.Parse(strnumber);
            label1.Text = intnumber.ToString();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (operatorChageFlag == true)
            {
                label1.Text = "";
                operatorChageFlag = false;
            }
            string strnumber = label1.Text += "3";
            double intnumber = double.Parse(strnumber);
            label1.Text = intnumber.ToString();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (operatorChageFlag == true)
            {
                label1.Text = "";
                operatorChageFlag = false;
            }
            string strnumber = label1.Text += "4";
            double intnumber = double.Parse(strnumber);
            label1.Text = intnumber.ToString();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (operatorChageFlag == true)
            {
                label1.Text = "";
                operatorChageFlag = false;
            }
            string strnumber = label1.Text += "5";
            double intnumber = double.Parse(strnumber);
            label1.Text = intnumber.ToString();
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (operatorChageFlag == true)
            {
                label1.Text = "";
                operatorChageFlag = false;
            }
            string strnumber = label1.Text += "6";
            double intnumber = double.Parse(strnumber);
            label1.Text = intnumber.ToString();
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChageFlag == true)
            {
                label1.Text = "";
                operatorChageFlag = false;
            }
            string strnumber = label1.Text += "7";
            double intnumber = double.Parse(strnumber);
            label1.Text = intnumber.ToString();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (operatorChageFlag == true)
            {
                label1.Text = "";
                operatorChageFlag = false;
            }
            string strnumber = label1.Text += "8";
            double intnumber = double.Parse(strnumber);
            label1.Text = intnumber.ToString();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (operatorChageFlag == true)
            {
                label1.Text = "";
                operatorChageFlag = false;
            }
            string strnumber = label1.Text += "9";
            double intnumber = double.Parse(strnumber);
            label1.Text = intnumber.ToString();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (operatorChageFlag == true)
            {
                label1.Text = "";
                operatorChageFlag = false;
            }
            string strnumber = label1.Text += "0";
            double intnumber = double.Parse(strnumber);
            label1.Text = intnumber.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator=Operators.None;
            label1.Text= "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(label1.Text);
            currentOperator = Operators.Divide;
            operatorChageFlag = true;
        }

        
        private void buttonMul_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(label1.Text);
            currentOperator = Operators.Multiply;
            operatorChageFlag = true;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            firstOperand=double.Parse(label1.Text);
            currentOperator = Operators.Substract;
            operatorChageFlag = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(label1.Text); //먼저 입력한 숫자를 정수형으로 바꾼 상태로 저장
            currentOperator = Operators.Add; //덧셈 버튼이 눌렸음을 알린다.
            operatorChageFlag= true; //먼저 출력된 값을 지우고 다시 숫자를 출력
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            secondOperand = double.Parse(label1.Text);
            if(currentOperator== Operators.Add)
            {
                firstOperand += secondOperand;
                label1.Text= firstOperand.ToString();
            }
            else if (currentOperator==Operators.Substract)
            {
                firstOperand -= secondOperand;
                label1.Text= firstOperand.ToString();
            }
            else if (currentOperator==Operators.Multiply)
            {
                firstOperand *= secondOperand;
                label1.Text= firstOperand.ToString();
            }
            else
            {
                if (secondOperand==0)
                {
                    label1.Text = "ERROR!!";
                }
                else
                {
                    firstOperand/= secondOperand;
                    label1.Text= firstOperand.ToString();
                }
            }
        }
    }
}
