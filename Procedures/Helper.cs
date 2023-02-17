using System.Collections;
using ESFCustomersData.Dtos;
using ESFCustomersData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ESFCustomersData.Procedures
{
    public static class Helper
    {
                
        public static ActionResult<IEnumerable<CustomerDto>> ConvertToDto(this IEnumerable<Symvolaia> customers)
        {
            List<Symvolaia> tempListOfCustomers = customers.ToList();
            List<CustomerDto> customersDTOS = new List<CustomerDto>();

            int i = 0;

            while (i < tempListOfCustomers.Count)
            {
                string tempSymbaseis = tempListOfCustomers[i].MNAME;

                if (i == tempListOfCustomers.Count - 1)
                {
                    customersDTOS.Add(AddDTOs(tempListOfCustomers, tempSymbaseis, i));
                    break;
                }

                if (tempListOfCustomers[i].afm.Equals(tempListOfCustomers[i + 1].afm))
                {
                    tempSymbaseis += "," + tempListOfCustomers[i + 1].MNAME;
                    
                    if (i + 2 < tempListOfCustomers.Count)
                    {
                        //var testaki = tempListOfCustomers[i + 2].afm;
                        if (tempListOfCustomers[i].afm.Equals(tempListOfCustomers[i + 2].afm))
                        {
                            tempSymbaseis += "," + tempListOfCustomers[i + 2].MNAME;

                            customersDTOS.Add(AddDTOs(tempListOfCustomers, tempSymbaseis, i));

                            i += 3;
                            continue;
                        }
                    }
                    
                    customersDTOS.Add(AddDTOs(tempListOfCustomers, tempSymbaseis, i));

                    i += 2;
                    continue;
                }

                customersDTOS.Add(AddDTOs(tempListOfCustomers, tempSymbaseis, i));

                i++;

            }

            return customersDTOS;
        }

        private static CustomerDto AddDTOs(List<Symvolaia> tempListOfCustomers, string tempSymbaseis, int i)
        {
            string[] symbaseis = tempSymbaseis.Split(",");

            int counter = i;
            
            CustomerDto cst = new CustomerDto()
            {
                Afm = tempListOfCustomers[i].afm,
                CustomerCode = tempListOfCustomers[i].CUSCODE,
                CustomerName = tempListOfCustomers[i].CUSNAME,
                Phone1 = tempListOfCustomers[i].phone01,
                Phone2 = tempListOfCustomers[i].phone02,
                Symvaseis = tempSymbaseis
            };


            foreach (var symbasi in symbaseis)
            {
                switch (symbasi)
                {
                    case "ΣΥΜΒΑΣΗ ΕΤΑΙΡΕΙΑΣ":
                        cst.SymvasiEtairias = "ΣΥΜΒΑΣΗ ΕΤΑΙΡΕΙΑΣ";
                        cst.LastSaleDateSymvasiEtairias += !String.IsNullOrEmpty(cst.LastSaleDateSymvasiEtairias)
                            ? "," + (tempListOfCustomers[i].LSALEDATE.HasValue ? tempListOfCustomers[i].LSALEDATE.Value.ToString("d"):string.Empty)
                            : (tempListOfCustomers[i].LSALEDATE.HasValue ? tempListOfCustomers[i].LSALEDATE.Value.ToString("d"):string.Empty);
                        cst.PriceSymvasiEtairias += Convert.ToDecimal(tempListOfCustomers[counter].PRICE);
                        cst.DiscountPriceSymvasiEtairias += Convert.ToDecimal(tempListOfCustomers[counter].DISCPRC / 100);
                        cst.DurationOfSymvasiEtairias += Convert.ToInt32(tempListOfCustomers[counter].QTY1);
                        cst.DateSymvasiEtairias += !String.IsNullOrEmpty(cst.DateSymvasiEtairias)
                            ? "," + (tempListOfCustomers[i].date01.HasValue ? tempListOfCustomers[i].date01.Value.ToString("d"):string.Empty)
                            : (tempListOfCustomers[i].date01.HasValue ? tempListOfCustomers[i].date01.Value.ToString("d"):string.Empty);
                        cst.FpriceSymvasiEtairias += Convert.ToDecimal(tempListOfCustomers[counter].fprice);
                        cst.TDurationOfSymvasiEtairias = Convert.ToInt32(tempListOfCustomers[counter].tqty);
                        cst.FpistOfSymvasiEtairias += !String.IsNullOrEmpty(cst.FpistOfSymvasiEtairias)
                            ? "," + tempListOfCustomers[i].fpist
                            : tempListOfCustomers[i].fpist;
                        break;
                    case "ΣΥΜΒΑΣΗ EPSILON":
                        cst.SymvasiEpsilon = "ΣΥΜΒΑΣΗ EPSILON";
                        cst.LastSaleDateSymvasiEpsilon += !String.IsNullOrEmpty(cst.LastSaleDateSymvasiEpsilon)
                            ? "," + (tempListOfCustomers[i].LSALEDATE.HasValue ? tempListOfCustomers[i].LSALEDATE.Value.ToString("d"):string.Empty)
                            : (tempListOfCustomers[i].LSALEDATE.HasValue ? tempListOfCustomers[i].LSALEDATE.Value.ToString("d"):string.Empty);
                        cst.PriceSymvasiEpsilon += Convert.ToDecimal(tempListOfCustomers[counter].PRICE);
                        cst.DiscountPriceSymvasiEpsilon += Convert.ToDecimal(tempListOfCustomers[counter].DISCPRC / 100);
                        cst.DurationOfSymvasiEpsilon += Convert.ToInt32(tempListOfCustomers[counter].QTY1);
                        cst.DateSymvasiEpsilon += !String.IsNullOrEmpty(cst.DateSymvasiEpsilon)
                            ? "," + (tempListOfCustomers[i].date01.HasValue ? tempListOfCustomers[i].date01.Value.ToString("d"):string.Empty)
                            : (tempListOfCustomers[i].date01.HasValue ? tempListOfCustomers[i].date01.Value.ToString("d"):string.Empty);
                        cst.FpriceSymvasiEpsilon += Convert.ToDecimal(tempListOfCustomers[counter].fprice);
                        cst.TDurationOfSymvasiEpsilon = Convert.ToInt32(tempListOfCustomers[counter].tqty);
                        cst.FpistOfSymvasiEpsilon += !String.IsNullOrEmpty(cst.FpistOfSymvasiEpsilon)
                            ? "," + tempListOfCustomers[i].fpist
                            : tempListOfCustomers[i].fpist;
                        break;
                    case "Cloud Hosting":
                        cst.CloudHosting = "Cloud Hosting";
                        cst.LastSaleDateCloudHosting += !String.IsNullOrEmpty(cst.LastSaleDateCloudHosting)
                            ? "," + (tempListOfCustomers[i].LSALEDATE.HasValue ? tempListOfCustomers[i].LSALEDATE.Value.ToString("d"):string.Empty)
                            : (tempListOfCustomers[i].LSALEDATE.HasValue ? tempListOfCustomers[i].LSALEDATE.Value.ToString("d"):string.Empty);
                        cst.PriceCloudHosting += Convert.ToDecimal(tempListOfCustomers[counter].PRICE);
                        cst.DiscountPriceCloudHosting += Convert.ToDecimal(tempListOfCustomers[counter].DISCPRC / 100);
                        cst.DurationOfCloudHosting += Convert.ToInt32(tempListOfCustomers[counter].QTY1);
                        cst.DateCloudHosting += !String.IsNullOrEmpty(cst.DateCloudHosting)
                            ? "," + (tempListOfCustomers[i].date01.HasValue ? tempListOfCustomers[i].date01.Value.ToString("d"):string.Empty)
                            : (tempListOfCustomers[i].date01.HasValue ? tempListOfCustomers[i].date01.Value.ToString("d"):string.Empty);
                        cst.FpriceCloudHosting += Convert.ToDecimal(tempListOfCustomers[counter].fprice);
                        cst.TDurationOfCloudHosting = Convert.ToInt32(tempListOfCustomers[counter].tqty);
                        cst.FpistOfCloudHosting += !String.IsNullOrEmpty(cst.FpistOfCloudHosting)
                            ? "," + tempListOfCustomers[i].fpist
                            : tempListOfCustomers[i].fpist;
                        break;
                }

                counter++;
            }

            return cst;

        }

    }
}
