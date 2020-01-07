using System.Linq;
using System.Collections.Generic;
using System;

namespace csharp_basic_lagi
{
    public class Task
    {
        //1.md
        public int jumlahKarakter (string word) {
            int jum = word.Length;
            Console.WriteLine ($"{jum}");
            return jum;
        }

        //2.md
        public string grade (int nilai) {
            if (nilai >= 90) {
                return "A";
            }
            else if (nilai >= 80 && nilai <= 89) {
                return "B";
            }
            else if (nilai >= 70 && nilai <= 79){
                return "C";
            }
            else if (nilai >= 60 && nilai <= 69) {
                return "D";
            }
            else if (nilai <= 59) {
                return "E";
            }
            return "F";
        }

        //3.md
        public string oddEven (int angka) {
            if (angka % 2 == 0) {
                return "Genap";
            } else {
                return "Ganjil";
            }
        }

        //4.md
        public string leapYear (int tahun) {
            if (tahun % 400 == 0) {
                return "Kabisat";
            } else {
                if (tahun % 100 == 0) {
                    return "Bukan Kabisat";
                } else {
                    if (tahun % 4 == 0) {
                        return "Kabisat";
                    } else {
                        return "Bukan Kabisat";
                    }
                }
            }
        }

        //5.md
        public string filmRating (int usia) {
            if (usia >= 21)
                return "Dewasa";
            else if (usia >= 13 && usia <= 20)
                return "Remaja";
            else if (usia >= 9 && usia <= 12)
                return "Bimbingan Orang Tua";
            else if (usia < 9)
                return "Semua Usia";
            return "Tidak Terkategori";
        }

        //6.md
        public List<int> loopRange (int angka1, int angka2) {
            List<int> loop = new List<int>();
            for (int i = angka1; i <= angka2; i++) {
                loop.Add(i);
            }
            return loop;
        }

        //7.md
        public List<int> oddGenerator (int angka) {
            List<int> ganjil = new List<int>();
            for (int i = 0; i < angka; i++) {
                if (i % 2 != 0) {
                    ganjil.Add(i);
                }
            }
            return ganjil;
        }

        //8.md
        public List<string> ganjilGenapKelipatan (int angka) {
            List<string> ganjilGenap = new List<string>();
            for (int i = 1; i <= angka; i++) {
                if (i % 100 == 0) {
                    ganjilGenap.Add ($"{i}. Kelipatan Seratus");
                } else if (i % 2 == 0 && i % 5 == 0) {
                    ganjilGenap.Add ($"{i}. Genap Kelipatan Lima");
                } else if (i % 2 != 0 && i % 5 == 0) {
                    ganjilGenap.Add ($"{i}. Ganjil Kelipatan Lima");
                } else if (i % 2 == 0) {
                    ganjilGenap.Add ($"{i}. Genap");
                } else if (i % 2 != 0) {
                    ganjilGenap.Add ($"{i}. Ganjil");
                }
            }
            return ganjilGenap;
        }

        //9.md
        public string balikKata (string input) {
            string[] inputUbah = input.Split();
            Array.Reverse(inputUbah);
            string hasil = String.Join(" ",inputUbah);
            return hasil;
        }

        //10.md
        public List<string> addToArray (string[] stuff) {
            List<string> stuffNew = stuff.ToList();
            stuffNew.Insert(0, "Handuk");
            stuffNew.Add("Celana");
            string[] stuffLagi = stuffNew.ToArray();
            return stuffLagi.ToList();
        }

    }
}
