using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();
            cd.Price = 666;
            Song song1 = new Song { Name = "Medicina Legalis Forensis(Mortui Vivos Docent)",Length = 1.07 };
            Song song2 = new Song { Name = "Proliferative Reaction of the Reticulo-endothelial System's Elements", Length = 0.52 };
            Song song3 = new Song { Name = "Medico-Legal Analysis of the Ethanol Levels in Cadaveric Blood and Organic Liquids", Length = 1.54  };
            Song song4 = new Song { Name = "Completely Liquefying Organs (Disgorging in Putrefaction)", Length = 0.24 };
            Song song5 = new Song { Name = "Gross Characteristics of the Cerebral Abcess in the Early Stage of Development", Length = 0.49 };
            Song song6 = new Song { Name = "Blenorrhagical Spermatocystities of Seminiferous Tubules", Length = 0.27 };
            Song song7 = new Song { Name = "Chronic Pachymeningitis with Diffuse Dura Mater Inspissation", Length = 0.46 }; 
            Song song8 = new Song { Name = "Multicystic Retroperitonial Sacrococcygenous Embryo-Teratoma", Length = 0.40 };
            Song song9 = new Song { Name = "Chronic Pro-Inflammatory Disorder in the Process of Himeno-Vulvo-Vaginal Auto-Disinfection", Length = 0.48 }; ;
            Song song10 = new Song { Name = "Fatal Pulmonary Embolism: Hystological Analysis", Length = 2.23 };
            Song song11 = new Song { Name = "Recessive Dystrophic Epidermolysis Bullosa", Length = 0.14 };
            Song song12 = new Song { Name = "Congenitally Acquired Retentive Liquid-Organic Hydropsia", Length = 0.52 };
            Song song13 = new Song { Name = "Insidious Colibacillosis of the Urinary Ways (Infectious-Inflammatory Pyocystities)", Length = 1.15 };
            Song song14 = new Song { Name = "Large Intestine Segmental Edematous Ileopathia", Length = 0.55 };
            Song song15 = new Song { Name = "Gruesome Aftermath of the Pathologist's Cadaveric Vilipend", Length = 1.47 };
            Song song16 = new Song { Name = "Secondary Dysmenorrhea Resulting from the Uterine Endometritis", Length = 0.45 };
            Song song17 = new Song { Name = "Malignant Intravenous Obstruction in Chronic Phlebothrombosis", Length = 1.25 };
            Song song18 = new Song { Name = "Hypothalamous Infundibulo Syndrome (Traumatic Cerebro-Vascular Accident)", Length = 2.04 };
            Song song19 = new Song { Name = "Hemorrhagical Affection of the Uterine Tract", Length = 1.03 };
            Song song20 = new Song { Name = "Recessive Enterological Ileo-Meconial Mucoviscidosis", Length = 1.49 };
            Song song21 = new Song { Name = "Mechanisms of Neutropenia Involving Malignant Myeloid Maturation", Length = 0.39 };
            Song song22 = new Song { Name = "Analysis of the Peritoneal Behavior in the Pelvic Cavity of the Female Genito-Urinary System", Length = 1.42 };
            Song song23 = new Song { Name = "Traumatic Obstetric Cerebro-Meningeal Hemorrhage", Length = 1.00 };
            Song song24 = new Song { Name = "Post-Mortem Analysis of the Inferior Vena Cava on a Pneumo-Embolous Affected Cadaver", Length = 0.29 };
            Song song25 = new Song { Name = "Functional Abnormalities of the Cardiac Structures Involving Chronic Myocardias", Length = 0.49 };
            Song song26 = new Song { Name = "Deranged Medico-Surgical Practices (Doctor Butcher M.D/ Medical Deviante)", Length = 1.39 };
            Song song27 = new Song { Name = "Abnormal Anastomosis Among the Diffuse Parts of the Arteriovenous Complex", Length = 1.31 };
            Song song28 = new Song { Name = "Duodenal Obstruction by Annular Pancreas in Embryogenesis", Length = 1.18 };
            Song song29 = new Song { Name = "Collateral Amyothopic Sclerosis of the Bulbo-Rachidian Extension", Length = 0.43 };
            Song song30 = new Song { Name = "Pathophysiologic Responses of Chronic Idiopathic Thrombocytopenic Purpura", Length = 1.14 };
            Song song31 = new Song { Name = "Petechial-Ecchymotic Widespread Hemorrhages (Characteristic Aspects of Meningococcemia)", Length = 2.29 };
            cd.Artist = "Lymphatic Phlegm";
            cd.Album = "Pathogenesis Infest Phlegmsepsia";
            cd.AddTrack(song1);
            cd.AddTrack(song2);
            cd.AddTrack(song3);
            cd.AddTrack(song4);
            cd.AddTrack(song5);
            cd.AddTrack(song6);
            cd.AddTrack(song7);
            cd.AddTrack(song8);
            cd.AddTrack(song9);
            cd.AddTrack(song10);
            cd.AddTrack(song11);
            cd.AddTrack(song12);
            cd.AddTrack(song13);
            cd.AddTrack(song14);
            cd.AddTrack(song15);
            cd.AddTrack(song16);
            cd.AddTrack(song17);
            cd.AddTrack(song18);
            cd.AddTrack(song19);
            cd.AddTrack(song20);
            cd.AddTrack(song21);
            cd.AddTrack(song22);
            cd.AddTrack(song23);
            cd.AddTrack(song24);
            cd.AddTrack(song25);
            cd.AddTrack(song26);
            cd.AddTrack(song27);
            cd.AddTrack(song28);
            cd.AddTrack(song29);
            cd.AddTrack(song30);
            cd.AddTrack(song31);
            Console.WriteLine(cd.ToString());
            cd.PrintSongMyBoi();

        }
    }
}
