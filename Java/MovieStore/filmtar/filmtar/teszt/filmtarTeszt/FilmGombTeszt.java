package filmtarTeszt;

import static org.junit.Assert.*;

import org.junit.Test;

import filmtar.Film;
import filmtar.FilmGomb;
import filmtar.Filmtar;
import filmtar.MainFrame;

public class FilmGombTeszt {

	@Test(expected = Exception.class)
	 public void ctorExTest() throws Exception
	 { 
		 Film f = new Film("", "", "", "", "", "", "","", "");
		 FilmGomb fg = new FilmGomb(f, null); 
		 assertTrue(fg.GetFilm().equals(f)); 
	 }	 
}