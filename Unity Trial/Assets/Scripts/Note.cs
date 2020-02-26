using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Note
{
    public string Name { get; private set; }      //ie 'A5'
    public  string Picture { get; private set; }  //image of whole note on a staff
    public  string Sound { get; private set; }    //audio file that plays
    public  int[] Fingering { get; private set; } //array to look for fingering

    public Note(string notename, string notepicture, string notesound, int[] notefingering)
    {
        this.Name = notename;
        this.Picture = notepicture;
        this.Sound = notesound;
        this.Fingering = notefingering;
    }

    public bool InputMatchesNote(int[] inputPattern)
    {
        if (inputPattern.SequenceEqual(Fingering))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
