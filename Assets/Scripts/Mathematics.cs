using System;
using UnityEngine;
using Random = System.Random;

public class Mathematics : MonoBehaviour
{
    private String equation = "";
    private String answer = "";
    
    public void combineLikeTerms()
    {
        Random luck = new Random();
        Random luck2 = new Random();
        Random luck3 = new Random();
        
        int variable = 0;
        int adsub = 0;
        int value = 0;

        int constant = 0;
        int x = 0;
        int y = 0;
        int xy = 0;

        for (int i = 0; i < 9; i++)
        {
            variable = luck.Next(1, 5);
            adsub = luck2.Next(1, 3);
            value = luck3.Next(1, 26);
            
            if (variable == 1)
            {
                if (i != 8)
                {
                    if (adsub == 1)
                    {
                        equation += value + " + ";
                        constant += value;
                    }
                    if (adsub == 2)
                    {
                        equation += value + " - ";
                        constant -= value;
                    }                    
                }
                else
                {
                    if (adsub == 1)
                    {
                        equation += value;
                        constant += value;
                    }
                    if (adsub == 2)
                    {
                        equation += value;
                        constant -= value;
                    }    
                }
            }
            if (variable == 2)
            {
                if (i != 8)
                {
                    if (adsub == 1)
                    {
                        equation += value + "x + ";
                        x += value;
                    }
                    if (adsub == 2)
                    {
                        equation += value + "x - ";
                        x -= value;
                    }                    
                }
                else
                {
                    if (adsub == 1)
                    {
                        equation += value + "x";
                        x += value;
                    }
                    if (adsub == 2)
                    {
                        equation += value + "x";
                        x -= value;
                    } 
                }
            }
            if (variable == 3)
            {
                if (i != 8)
                {
                    if (adsub == 1)
                    {
                        equation += value + "y + ";
                        y += value;
                    }
                    if (adsub == 2)
                    {
                        equation += value + "y - ";
                        y -= value;
                    }                    
                }
                else
                {
                    if (adsub == 1)
                    {
                        equation += value + "y";
                        y += value;
                    }
                    if (adsub == 2)
                    {
                        equation += value + "y";
                        y -= value;
                    }
                }
            }
            if (variable == 4)
            {
                if (i != 8)
                {
                    if (adsub == 1)
                    {
                        equation += value + "xy + ";
                        xy += value;
                    }
                    if (adsub == 2)
                    {
                        equation += value + "xy - ";
                        xy -= value;
                    }                    
                }
                else
                {
                    if (adsub == 1)
                    {
                        equation += value + "xy";
                        xy += value;
                    }
                    if (adsub == 2)
                    {
                        equation += value + "xy";
                        xy -= value;
                    }
                }
            }
        }
        answer = xy + "xy + " + x + "x + " + y + "y + " + constant;
        print("Equation: " + equation);
        print("Answer: " + answer);
    }
    
    public void distribute()
    {
        Random luck = new Random();
        Random luck2 = new Random();

        int distributee = luck.Next(1, 9);
        int distributeY = luck.Next(1, 25);
        int distributeC = luck.Next(1, 25);
        int distributeX = luck.Next(1, 25);
        int sign = 0;
        
        sign = luck2.Next(1, 3);
        if (sign == 1)
        {
            equation += distributee + "(";
        }
        if (sign == 2)
        {
            equation += "-" + distributee + "(";
            distributee *= -1;
        }

        sign = luck2.Next(1, 3);
        if (sign == 1)
        {
            equation += distributeX + "x";
            answer += distributee * distributeX + "x";
        }
        if (sign == 2)
        {
            equation += "-" + distributeX + "x";
            distributeX *= -1;
            answer += distributee * distributeX + "x";
        }

        sign = luck2.Next(1, 3);
        if (sign == 1)
        {
            equation += " + " + distributeY + "y";
            answer += " + " + distributee * distributeY + "y";
        }

        if (sign == 2)
        {
            equation += " - " + distributeY + "y";
            distributeY *= -1;
            answer += " + " + distributee * distributeY + "y";
        }    
        
        sign = luck2.Next(1, 3);
        if (sign == 1)
        {
            equation += " + " + distributeC + ")";
            answer += " + " + distributee * distributeC;
        }

        if (sign == 2)
        {
            equation += " - " + distributeC + ")";
            distributeC *= -1;
            answer += " + " + distributee * distributeC;
        }
        print("Equation: " + equation);
        print("Answer: " + answer);
    }

    public void inequalities()
    {
        Random luck = new Random();
        Random luck2 = new Random();
        Random luck3 = new Random();

        int gator = luck2.Next(1, 3);

        int sign = luck.Next(1, 3);
        int value = luck3.Next(1, 26);
        if (sign == 2) value *= -1;
        if (gator == 1) equation += value + " > ";
        if (gator == 2) equation += value + " < ";

        double answerHolder = 0;
        
        int sign2 = luck.Next(1, 3);
        int value2 = luck3.Next(1, 26);
        if (sign2 == 2) value2 *= -1;
        equation += value2 + "x";
        
        int sign3 = luck.Next(1, 3);
        int value3 = luck3.Next(1, 26);
        if (sign3 == 1) equation += " + " + value3;
        if (sign3 == 2) equation += " - " + value3;

        if (sign3 == 2) answerHolder = value + value3;
        else answerHolder = value - value3;

        answerHolder /= value2;

        if (sign2 == 2)
        {
            if (gator == 1) answer = "x > " + answerHolder;
            if (gator == 2) answer = "x < " + answerHolder;
        }
        else
        {
            if (gator == 1) answer = "x < " + answerHolder;
            if (gator == 2) answer = "x > " + answerHolder;
        }
        print("Equation: " + equation);
        print("Answer: " + answer);
    }

    public void areas()
    {
        Random luck = new Random();
        Random luck2 = new Random();

        int which = luck.Next(1, 4);

        if (which == 1)
        {
            int radius = luck2.Next(1, 26);
            
            double answerHolder = radius * radius * 3.142;

            equation = "What is the area of a circle with a radius of " + radius +
                       "? Round to the nearest thousandths place.";
            answer = Math.Round(answerHolder, 3) + "";
            
            print("Equation: " + equation);
            print("Answer: " + answer);
        }
        if (which == 2)
        {
            int baseVal = luck2.Next(1, 26);
            int heightVal = luck2.Next(1, 26);

            int answerHolder = baseVal * heightVal;

            equation = "What is the area of a square with a height of " + heightVal + " and a base of " +
                       baseVal + "?";
            answer = answerHolder + "";

            print("Equation: " + equation);
            print("Answer: " + answer);
        }
        if (which == 3)
        {
            int baseVal = luck2.Next(1, 26);
            int heightVal = luck2.Next(1, 26);

            int answerHolder = baseVal * heightVal / 2;

            equation = "What is the area of a triangle with a height of " + heightVal + " and a base of " +
                       baseVal + "?";
            answer = answerHolder + "";

            print("Equation: " + equation);
            print("Answer: " + answer);
        }
    }

    public void volumes()
    {
        Random luck = new Random();
        Random luck2 = new Random();

        int which = luck.Next(1, 4);

        if (which == 1)
        {
            int radius = luck2.Next(1, 26);
            
            double answerHolder = radius * radius * radius;
            answerHolder *= 4;
            answerHolder /= 3;
            answerHolder *= 3.142;

            equation = "Equation: What is the volume of a sphere with a radius of " + radius +
                       "? Round to the nearest thousandths place.";
            answer = Math.Round(answerHolder, 3) + "";
            
            print(equation);
            print("Answer: " + answer);
        }
        if (which == 2)
        {
            int widthVal = luck2.Next(1, 26);
            int heightVal = luck2.Next(1, 26);
            int lengthVal = luck2.Next(1, 26);

            int answerHolder = widthVal * heightVal * lengthVal;

            equation = "Equation: What is the volume of a cube with a height of " + heightVal + ", a width of " +
                       widthVal + ", and a length of " + lengthVal + "?";
            answer = "Answer: " + answerHolder;

            print(equation);
            print(answer);
        }

        if (which == 3)
        {
            int baseHVal = luck2.Next(1, 26);
            int baseLVal = luck2.Next(1, 26);
            int heightVal = luck2.Next(1, 26);

            double answerHolder = baseLVal * baseHVal / 2;
            answerHolder *= heightVal;

            equation = "Equation: What is the volume of a triangular prism with a base height of " + baseHVal +
                       ", a base length of " + baseLVal + ", and an overall height of " + heightVal + "?";
            answer = "Answer: " + answerHolder;

            print(equation);
            print(answer);
        }
    }

    public void slopeIntercept()
    {
        Random luck = new Random();

        int x1 = luck.Next(1, 10);
        int y1 = luck.Next(1, 10);
        int x2 = luck.Next(1, 10);
        int y2 = luck.Next(1, 10);

        while (y2 == y1) y2 = luck.Next(1, 10);
        while (x2 == x1) x2 = luck.Next(1, 10);

        double answerHolder2 = y2 - y1;
        double answerHolder3 = x2 - x1;
        double slope = Math.Round(answerHolder2 / answerHolder3, 3);

        answer = "y = " + slope + "x";

        double answerHolder4 = x2 * slope;
        double answerHolder5 = y2 - answerHolder4;

        equation = "What is the equation of the line that passes through (" + x1 + "," + y1 + ") and (" + x2 +
                   "," + y2 + ")? Round slope to the nearest thousandths place.";
        if (answerHolder5 < 0) answer += " - " + Math.Abs(answerHolder5);
        else answer += " + " + answerHolder5;
        
        print("Equation: " + equation);
        print("Answer: " + answer);
    }

    public void multiPoly()
    {
        Random luck = new Random();

        int value1 = luck.Next(1, 26);
        int value2 = luck.Next(1, 26);
        int value3 = luck.Next(1, 26);
        int value4 = luck.Next(1, 26);
        int value5 = luck.Next(1, 26);
        int value6 = luck.Next(1, 26);

        int med1 = value1 * value4;
        int med2 = value1 * value5;
        int med3 = value1 * value6;
        int med4 = value2 * value4;
        int med5 = value2 * value5;
        int med6 = value2 * value6;
        int med7 = value3 * value4;
        int med8 = value3 * value5;
        int med9 = value3 * value6;

        int xpower = med1;
        int ypower = med9;
        int xy = med3 + med7;
        int x = med2 + med4;
        int y = med6 + med8;
        int cons = med5;

        equation = "(" + value1 + "x + " + value2 + " + " + value3 + "y) (" + value4 + "x + " + value5 + " + " + value6 + "y)";
        answer = xpower + "x^2 + " + ypower + "y^2 + " + xy + "xy + " + x + "x + " + y + "y + " + cons;

        print("Equation: " + equation);
        print("Answer: " + answer);
    }

    public void powers()
    {
        Random luck = new Random();
        Random luck2 = new Random();
        Random luck3 = new Random();

        int which = luck.Next(1, 3);
        int baseVal = luck2.Next(1, 4);
        int expVal1 = luck3.Next(1, 6);
        int expVal2 = luck3.Next(1, 6);

        int exponent = 0;
        
        if (which == 1)
        {
            exponent = expVal1 + expVal2;
            int answerHolder = baseVal;
            int answerHolder2 = baseVal;
            for (int i = 0; i < exponent - 1; i++)
            {
                answerHolder = answerHolder * answerHolder2;
                print(answerHolder);
            }
            equation = "(" + baseVal + "^" + expVal1 + ") (" + baseVal + "^" + expVal2 + ")";
            answer = answerHolder + "";
        }
        if (which == 2)
        {
            exponent = expVal1 * expVal2;
            int answerHolder = baseVal;
            int answerHolder2 = baseVal;
            for (int i = 0; i < exponent - 1; i++)
            {
                answerHolder = answerHolder * answerHolder2;
                print(answerHolder);
            }
            equation = "(" + baseVal + "^" + expVal1 + ")^" + expVal2;
            answer = answerHolder + "";
        }
        print("Equation: " + equation);
        print("Answer: " + answer);
    }

    public void shifts()
    {
        Random luck = new Random();

        int reflection = luck.Next(1, 3);
        int ifStretch = luck.Next(1, 3);
        int stretchVal = luck.Next(1, 10);
        int hWay = luck.Next(1, 3);
        int hShift = luck.Next(0, 26);
        int vWay = luck.Next(1, 3);
        int vShift = luck.Next(0, 26);

        if (reflection == 1)
        {
            answer += "No reflection across x-axis, ";
            if (ifStretch == 1)
            {
                answer += "Vertical stretch with a factor of " + stretchVal + ", ";
                if (hWay == 1)
                {
                    answer += "Horizontal shift right " + hShift + " units, ";
                    if (vWay == 1)
                    {
                        equation = "Shifts of " + stretchVal + "(x - " + hShift + ") + " + vShift;
                        answer += "Vertical shift up " + vShift + " units.";
                    }
                    if (vWay == 2)
                    {
                        equation = "Shifts of " + stretchVal + "(x - " + hShift + ") - " + vShift;
                        answer += "Vertical shift down " + vShift + " units.";
                    }
                }
                if (hWay == 2)
                {
                    answer += "Horizontal shift left " + hShift + " units, ";
                    if (vWay == 1)
                    {
                        equation = "Shifts of " + stretchVal + "(x + " + hShift + ") + " + vShift;
                        answer += "Vertical shift up " + vShift + " units.";
                    }
                    if (vWay == 2)
                    {
                        equation = "Shifts of " + stretchVal + "(x + " + hShift + ") - " + vShift;
                        answer += "Vertical shift down " + vShift + " units.";
                    }
                }
            }
            if (ifStretch == 2)
            {
                answer += "Vertical compression with a factor of 1/" + stretchVal + ", ";
                if (hWay == 1)
                {
                    answer += "Horizontal shift right " + hShift + " units, ";
                    if (vWay == 1)
                    {
                        equation = "Shifts of 1/" + stretchVal + "(x - " + hShift + ") + " + vShift;
                        answer += "Vertical shift up " + vShift + " units.";
                    }
                    if (vWay == 2)
                    {
                        equation = "Shifts of 1/" + stretchVal + "(x - " + hShift + ") - " + vShift;
                        answer += "Vertical shift down " + vShift + " units.";
                    }
                }
                if (hWay == 2)
                {
                    answer += "Horizontal shift left " + hShift + " units, ";
                    if (vWay == 1)
                    {
                        equation = "Shifts of 1/" + stretchVal + "(x + " + hShift + ") + " + vShift;
                        answer += "Vertical shift up " + vShift + " units.";
                    }
                    if (vWay == 2)
                    {
                        equation = "Shifts of 1/" + stretchVal + "(x + " + hShift + ") - " + vShift;
                        answer += "Vertical shift down " + vShift + " units.";
                    }
                }
            }
        }
        if (reflection == 2)
        {
            answer += "Reflection across x-axis, ";
            if (ifStretch == 1)
            {
                answer += "Vertical stretch with a factor of " + stretchVal + ", ";
                if (hWay == 1)
                {
                    answer += "Horizontal shift right " + hShift + " units, ";
                    if (vWay == 1)
                    {
                        equation = "Shifts of -" + stretchVal + "(x - " + hShift + ") + " + vShift;
                        answer += "Vertical shift up " + vShift + " units.";
                    }
                    if (vWay == 2)
                    {
                        equation = "Shifts of -" + stretchVal + "(x - " + hShift + ") - " + vShift;
                        answer += "Vertical shift down " + vShift + " units.";
                    }
                }
                if (hWay == 2)
                {
                    answer += "Horizontal shift left " + hShift + " units, ";
                    if (vWay == 1)
                    {
                        equation = "Shifts of -" + stretchVal + "(x + " + hShift + ") + " + vShift;
                        answer += "Vertical shift up " + vShift + " units.";
                    }
                    if (vWay == 2)
                    {
                        equation = "Shifts of -" + stretchVal + "(x + " + hShift + ") - " + vShift;
                        answer += "Vertical shift down " + vShift + " units.";
                    }
                }
            }
            if (ifStretch == 2)
            {
                answer += "Vertical compression with a factor of 1/" + stretchVal + ", ";
                if (hWay == 1)
                {
                    answer += "Horizontal shift right " + hShift + " units, ";
                    if (vWay == 1)
                    {
                        equation = "Shifts of -1/" + stretchVal + "(x - " + hShift + ") + " + vShift;
                        answer += "Vertical shift up " + vShift + " units.";
                    }
                    if (vWay == 2)
                    {
                        equation = "Shifts of -1/" + stretchVal + "(x - " + hShift + ") - " + vShift;
                        answer += "Vertical shift down " + vShift + " units.";
                    }
                }
                if (hWay == 2)
                {
                    answer += "Horizontal shift left " + hShift + " units, ";
                    if (vWay == 1)
                    {
                        equation = "Shifts of -1/" + stretchVal + "(x + " + hShift + ") + " + vShift;
                        answer += "Vertical shift up " + vShift + " units.";
                    }
                    if (vWay == 2)
                    {
                        equation = "Shifts of -1/" + stretchVal + "(x + " + hShift + ") - " + vShift;
                        answer += "Vertical shift down " + vShift + " units.";
                    }
                }
            }
        }
        print("Equation: " + equation);
        print("Answer: " + answer);
    }

    public void eulerIdentity()
    {
        equation = "What number to power of 1/πi is equal to -1?";
        answer = -1 + "";
        
        print("Equation: " + equation);
        print("Answer: " + answer);
    }

    public void standardDeviation()
    {
        Random luck = new Random();

        double data1 = luck.Next(0, 26);
        double data2 = luck.Next(0, 26);
        double data3 = luck.Next(0, 26);
        double data4 = luck.Next(0, 26);
        double data5 = luck.Next(0, 26);

        double avg = (data1 + data2 + data3 + data4 + data5) / 5;

        double answerHolder = data1 - avg;
        answerHolder *= answerHolder;
        double answerHolder2 = data2 - avg;
        answerHolder2 *= answerHolder2;
        double answerHolder3 = data3 - avg;
        answerHolder3 *= answerHolder3;
        double answerHolder4 = data4 - avg;
        answerHolder4 *= answerHolder4;
        double answerHolder5 = data5 - avg;
        answerHolder5 *= answerHolder5;

        double sigma = answerHolder + answerHolder2 + answerHolder3 + answerHolder4 + answerHolder5;
        sigma /= 4;

        double stanDev = Math.Sqrt(sigma);

        equation = "Find the standard deviation of {" + data1 + ", " + data2 + ", " + data3 + ", " + data4 + ", " + data5 + "}. Round do the nearest tenths place.";
        answer = Math.Round(stanDev, 1) + "";
        
        print("Equation: " + equation);
        print("Answer: " + answer);
    }

    public void trigProofs()
    {
        equation = "Simplify sin^2X(cot^2X).";
        answer = "cos^2X";
        
        print("Equation: " + equation);
        print("Answer: " + answer);
    }
}    