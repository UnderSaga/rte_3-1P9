﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Grop
    {
        public int Id { get; set; }
        public int SubGroup { get; set; }
        public int ClassRoom { get; set; }
        public Special Special { get; set; }
        public int StartYear { get; set; }
        public string GetCode()
        {
            int kourse = DateTime.Now.Year - StartYear;
            if (DateTime.Now.Month >= 9)
                kourse++;
            return $"{kourse}-{SubGroup}{Special.Code}{ClassRoom}";
        }

        public static void CreateGrop() {
            using (var db = new DBContext()) {
                Special special = new Special { Code = 'П', Name = "Программисты" };
                db.Specials.Add(special);
                for (int y = 0; y < 4; y++)
                {
                    for (int sg = 0; sg < 2; sg++)
                    {
                        Grop grop = new Grop
                        {
                            ClassRoom = 9,
                            SubGroup = sg,
                            StartYear = 2019 + y,
                            Special = special
                        };
                        db.Grops.Add(grop);
                    }
                }
            }
        }
    }
}
