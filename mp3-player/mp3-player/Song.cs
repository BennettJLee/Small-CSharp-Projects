﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mp3_player
{
    /// <summary>
    /// stores information about a single song
    /// </summary>
    public class Song
    {
        public int id; //integer variable for song id
        public string path; //string variable for song filename
        public int rating; //integer variable for song rating
        public ID3 tags; //Song 'has a' ID3 tag object for song tags 

        public Song(int id, string path, int rating)
        {
            this.id = id;
            this.path = path;
            this.rating = rating;
            tags = new ID3(path);
        }

        public string Songname
        {
            get
            {
                string[] array;
                string name;
                array = path.Split('\\'); //split up path
                name = array[array.Length - 1]; //get last part of path = filename
                name = name.Substring(0, name.Length - 4); //remove '.mp3'
                return name;
            }
        }

        public int Id
        {
            get { return this.id; }
        }

        public string Path
        {
            get { return this.path; }
        }
        public int Rating
        {
            get { return this.rating; }
        }

        public string ToCSVString()
        {
            return Id.ToString() + ", " + Path + ", " + Rating.ToString();
        }
    }
}
