using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mathcode : MonoBehaviour
{
    int[] MathEAA1 = new int[99];
    int[] MathEAB1 = new int[99];
    int[] MathEAC1 = new int[99];
    int[] MathEAD1 = new int[99];

    int Num1 = 0, Num2 = 0;
    public Text calculateFactor1; //แสดงตัวประกอบ Num1
    public Text calculateFactor2; //แสดงตัวประกอบ Num2
    public Text calculateFactor3; //แสดง Euclidean algorithm 
    public Text calculateFactor4; //แสดงผลลัพท์ 
    public int a, b, numclone1 = 55, numclone2 = 54, memeorynum = 1, NumEA1 = 2, NUMEA2 = 1 ,gcd;

    void Start()
    {
        numclone1 = 55;
        numclone2 = 54;
    }

    void Update()
    {



    }


    public void Math()
    {
    }


    //หาตัวประกอบ
    public void Getinput(string num1)
    {
        calculateFactor1.text = "";
        calculateFactor3.text = "";
        numclone1 = int.Parse(num1); ;
        NumEA1 = numclone1;
        NUMEA2 = numclone2;
        int arraynum = 1;

        for (int Numdivide = 2; Numdivide <= numclone1; Numdivide++)
        {
            if (numclone1 % Numdivide == 0)
            {
                calculateFactor1.text += Numdivide + "  ";
                numclone1 = numclone1 / Numdivide;
                Numdivide = 1;
            }
        }
    }

    public void Getinput2(string num2)
    {
        calculateFactor2.text = "";
        calculateFactor3.text = "";
        numclone2 = int.Parse(num2); ;
        NumEA1 = numclone1;
        NUMEA2 = numclone2;
        int arraynum2 = 1;

        for (int Numdivide2 = 2; Numdivide2 <= numclone2; Numdivide2++)
        {
            if (numclone2 % Numdivide2 == 0)
            {
                if (numclone2 % Numdivide2 == 0)
                {
                    calculateFactor2.text += Numdivide2 + "  ";
                    numclone2 = numclone2 / Numdivide2;
                    Numdivide2 = 1;
                }

            }
        }
    }

    public void GetiCheckNum(string num1)
    {
        if (numclone1 != 0 && numclone2 != 0)
        {
            calculateFactor3.text = "";
            numclone1 = int.Parse(num1); ;

            if (numclone1 > numclone2)
            {
                NumEA1 = numclone1;
                NUMEA2 = numclone2;
            }
            if (numclone2 > numclone1)
            {
                NumEA1 = numclone2;
                NUMEA2 = numclone1;
            }



            for (int GCDNUM = 1; GCDNUM <= numclone1 && GCDNUM <= numclone2; ++GCDNUM)
            {
                if (numclone1 % GCDNUM == 0 && numclone2 % GCDNUM == 0)
                    gcd = GCDNUM;
                calculateFactor4.text = " GCD : " + gcd;
            }


            for (int check = 1, i = NumEA1; i >= 1 && check != 2; i--)
            {
                if (NumEA1 - (i * NUMEA2) >= 0)
                {

                    MathEAA1[memeorynum] = NumEA1;
                    MathEAB1[memeorynum] = NUMEA2;
                    MathEAC1[memeorynum] = i;
                    MathEAD1[memeorynum] = NumEA1 - (i * NUMEA2);
                    calculateFactor3.text += MathEAA1[memeorynum] + " = ( " + MathEAB1[memeorynum] + " * " + MathEAC1[memeorynum] + " )  - " + MathEAD1[memeorynum] + "\n";

                    if (MathEAD1[memeorynum] == 0)
                    {
                        check = 2;
                    }


                    NumEA1 = NUMEA2;
                    NUMEA2 = MathEAD1[memeorynum];
                    i = NumEA1;

                    if (MathEAD1[memeorynum] == 1)
                    {
                        calculateFactor3.text += NumEA1 + " = (  1 * " + NumEA1 + " )  -  0 \n";
                        check = 2;
                    }

                    ++memeorynum;

                }


            }
            memeorynum = 0;
            return;
        }
    }



    public void GetiCheckNum2(string num2)
    {

        if (numclone1 != 0 && numclone2 != 0)
        {
            calculateFactor3.text = "";
            numclone2 = int.Parse(num2); ;

            if (numclone1 > numclone2)
            {
                NumEA1 = numclone1;
                NUMEA2 = numclone2;
            }
            if (numclone2 > numclone1)
            {
                NumEA1 = numclone2;
                NUMEA2 = numclone1;
            }


            for (int GCDNUM = 1; GCDNUM <= numclone1 && GCDNUM <= numclone2; ++GCDNUM)
            {
                if (numclone1 % GCDNUM == 0 && numclone2 % GCDNUM == 0)
                    gcd = GCDNUM;
                calculateFactor4.text = " GCD : " + gcd;
            }


            for (int check = 1, i = NumEA1; i >= 0 && check != 2; i--)
            {
                if (NumEA1 - (i * NUMEA2) >= 0)
                {

                    MathEAA1[memeorynum] = NumEA1;  //123
                    MathEAB1[memeorynum] = NUMEA2;  //33
                    MathEAC1[memeorynum] = i;  //3
                    MathEAD1[memeorynum] = NumEA1 - (i * NUMEA2);   //24
                    calculateFactor3.text += MathEAA1[memeorynum] + " = ( " + MathEAB1[memeorynum] + " * " + MathEAC1[memeorynum] + " )  - " + MathEAD1[memeorynum] + "\n";

                    if (MathEAD1[memeorynum] == 0)
                    {
                        check = 2;
                    }

                    NumEA1 = NUMEA2;  //33
                    NUMEA2 = MathEAD1[memeorynum];  //24
                    i = NumEA1;  //33

                    if (MathEAD1[memeorynum] == 1)
                    {
                        calculateFactor3.text += NumEA1 + " = (  1 * " + NumEA1 + " )  -  0 \n";
                        check = 2;
                    }

                    ++memeorynum;  //3


                }


            }
        }
        memeorynum = 0;
        return;
    }

}