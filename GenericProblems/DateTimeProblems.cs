using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericProblems
{
    class DateTimeProblems
    {
        string newdate = "";
        public string GetDateAfterDays(int givenDays, string givendate)
        {
            string message = "";
            int dd, mm, yyyy;
            dd = mm = yyyy = 0;
            if (givenDays > 0)
            {
                if (!string.IsNullOrEmpty(givendate))
                {
                    string[] dateparts = givendate.Split('-');
                    if (dateparts.Length == 3)
                    {
                        Int32.TryParse(dateparts[0], out dd);
                        Int32.TryParse(dateparts[1], out mm);
                        Int32.TryParse(dateparts[2], out yyyy);
                        //if (dd+givenDays < 365)
                        //{
                        if (mm == 2)
                        {
                            if (yyyy % 4 == 0)
                            {
                                if (dd <= 29)
                                {
                                    if (givenDays + dd > 29)
                                    {
                                        mm++;
                                        givenDays = givenDays + dd - 29;
                                        if (givenDays > 31)
                                        {
                                            dd = 0;
                                        }
                                        else
                                        {
                                            dd = givenDays;
                                            givenDays = 0;
                                        }
                                        message = dd + "-" + mm + "-" + yyyy;
                                        GetDateAfterDays(givenDays, message);
                                    }
                                    else
                                    {
                                        dd = dd + givenDays;
                                        message = dd + "-" + mm + "-" + yyyy;
                                    }
                                }
                                else
                                {
                                    message = "date can not be greater than 29 in February";
                                }
                            }
                            else if (dd <= 28)
                            {
                                if (dd + givenDays >= 28)
                                {
                                    mm++;
                                    givenDays = givenDays + dd - 28;
                                    if (givenDays > 31)
                                    {
                                        dd = 0;
                                    }
                                    else
                                    {
                                        dd = givenDays;
                                        givenDays = 0;
                                    }
                                    message = dd + "-" + mm + "-" + yyyy;
                                    GetDateAfterDays(givenDays, message);
                                }
                                else
                                {
                                    dd = dd + givenDays;
                                    message = dd + "-" + mm + "-" + yyyy;
                                }
                            }
                            else
                            {
                                message = "date can not be greater than 28 days";
                            }
                        }
                        else
                        {
                            if (mm == 1 || mm == 3 || mm == 5 || mm == 7 || mm == 8 || mm == 10 || mm == 12)
                            {
                                if (dd < 31)
                                {
                                    if (dd + givenDays > 31)
                                    {
                                        if (mm == 12)
                                        {
                                            mm = 1;
                                            yyyy++;
                                        }
                                        else
                                        {
                                            mm++;
                                        }
                                        givenDays = givenDays + dd - 31;
                                        if (mm != 2)
                                        {
                                            if (givenDays > 30)
                                            {
                                                dd = 0;
                                            }
                                            else
                                            {
                                                dd = givenDays;
                                                givenDays = 0;
                                            }
                                        }
                                        else
                                        {
                                            if (yyyy % 4 == 0)
                                            {
                                                if (givenDays > 29)
                                                {
                                                    dd = 0;
                                                }
                                                else
                                                {
                                                    dd = givenDays;
                                                    givenDays = 0;
                                                }
                                            }
                                            else
                                            {
                                                if (givenDays > 28)
                                                {
                                                    dd = 0;
                                                }
                                                else
                                                {
                                                    dd = givenDays;
                                                    givenDays = 0;
                                                }
                                            }
                                        }
                                        message = dd + "-" + mm + "-" + yyyy;
                                        GetDateAfterDays(givenDays, message);
                                    }
                                    else
                                    {
                                        dd += givenDays;
                                        message = dd + "-" + mm + "-" + yyyy;
                                    }
                                }
                                else
                                {
                                    message = "date can not be greater than 31 in given month.";
                                }
                            }
                            else if (mm == 4 || mm == 6 || mm == 9 || mm == 11)
                            {
                                if (dd < 30)
                                {
                                    if (dd + givenDays > 30)
                                    {
                                        mm++;
                                        givenDays = givenDays + dd - 30;
                                        if (givenDays > 31)
                                        {
                                            dd = 0;
                                        }
                                        else
                                        {
                                            dd = givenDays;
                                            givenDays = 0;
                                        }
                                        message = dd + "-" + mm + "-" + yyyy;
                                        GetDateAfterDays(givenDays, message);
                                    }
                                    else
                                    {
                                        dd += givenDays;
                                        message = dd + "-" + mm + "-" + yyyy;
                                    }
                                }
                                else
                                {
                                    message = "date can not be greater than 30 in given month.";
                                }
                            }
                        }
                        //}
                        //else
                        //{
                        //    //int y = givenDays / 365;
                        //    //yyyy++;// = yyyy + y;
                        //    //if (yyyy % 4 == 0 || (mm>2 && (yyyy+1)%4==0))
                        //    //{
                        //    //    givenDays = givenDays - 366;
                        //    //    dd--;
                        //    //}
                        //    //else 
                        //    //{
                        //    //    givenDays = givenDays - 365;
                        //    //}

                        //    //yyyy++;

                        //    ////int dds = givenDays % 365;
                        //    //message = dd + "-" + mm + "-" + yyyy;
                        //    //GetDateAfterDays(givenDays, message);
                        //}
                    }
                    else
                    {
                        message = "Given date is not in correct format.";
                    }
                }
                else
                {
                    message = "Invalid date";
                }
            }
            else
            {
                newdate = givendate;
                message = givendate;
            }
            return newdate;
        }
    }
}
