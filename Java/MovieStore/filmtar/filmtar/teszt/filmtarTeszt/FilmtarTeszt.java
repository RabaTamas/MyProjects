package filmtarTeszt;

import static org.junit.Assert.*;
import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.Test;

import filmtar.Film;
import filmtar.Filmtar;

public class FilmtarTeszt {

	@Test
	public void searchTest() throws Exception {
		Filmtar t = new Filmtar();
		Film f1 = new Film();
		f1.setCim("Hello");
		Film f2 = new Film();
		f2.setCim("Bello");
		t.add(f1);
		t.add(f2);
		assertEquals("Hello", t.Search("Hello").get(0).getCim());
	}
	@Test
	public void loadTest()
	{
		Filmtar t = new Filmtar();;
		try
		{
			t.load("filmtest.txt");
		}
		catch(Exception ex)
		{
			
		}
		assertEquals(0, t.Length());
	}
	@Test(expected = Exception.class)
	public void loadTestException() throws Exception
	{
		Filmtar t = new Filmtar();;
		t.load("");
		assertEquals(5, t.Length());
	}

}
