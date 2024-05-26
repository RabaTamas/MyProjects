package filmtarTeszt;

import static org.junit.Assert.*;

import org.junit.Test;

import filmtar.Film;
import filmtar.FilmGomb;

public class FIlmTeszt {

	@Test 
	 public void ctorTest() throws Exception
	 { 
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 FilmGomb fg = new FilmGomb(f, null); 
		 assertTrue(fg.GetFilm().equals(f)); 
	 }
	 
	 @Test
	 public void setCimTest() throws Exception
	 {
		 Film f = new Film();
		 f.setCim("Hello");
		 assertEquals("Hello", f.getCim());
	 }
	 
	 @Test(expected = Exception.class)
	 public void setCimTestEx() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setCim("");
		 assertEquals("Hello", f.getCim());
	 }
	 
	 @Test
	 public void setEredetiCimTest() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setEredetiCim("Hello");
		 assertEquals("Hello", f.getEredetiCim());
	 }
	 
	 @Test(expected = Exception.class)
	 public void setEredetiCimTestEx() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setEredetiCim("");
		 assertEquals("Hello", f.getEredetiCim());
	 }
	 
	 @Test
	 public void setRendezoTest() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setRendezo("Hello");
		 assertEquals("Hello", f.getRendezo());
	 }
	 
	 @Test(expected = Exception.class)
	 public void setRendezoTestEx() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setRendezo("");
		 assertEquals("Hello", f.getRendezo());
	 }
	 
	 @Test
	 public void setLeirasTest() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setLeiras("Hello");
		 assertEquals("Hello", f.getLeiras());
	 }
	 
	 @Test(expected = Exception.class)
	 public void setLeirasTestEx() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setLeiras("");
		 assertEquals("Hello", f.getLeiras());
	 }
	 
	 @Test
	 public void setMufajTest() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setMufaj("Hello");
		 assertEquals("Hello", f.getMufaj());
	 }
	 
	 @Test(expected = Exception.class)
	 public void setMufajTestEx() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setMufaj("");
		 assertEquals("Hello", f.getMufaj());
	 }
	 
	 @Test
	 public void setEvTest() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setEv("0");
		 assertEquals(0, f.getEv());
	 }
	 
	 @Test(expected = Exception.class)
	 public void setEvTestEx() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setEv("");
		 assertEquals("0", f.getEv());
	 }
	 
	 @Test
	 public void setKorTest() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setKorhatar("0");
		 assertEquals(0, f.getKorhatar());
	 }
	 
	 @Test(expected = Exception.class)
	 public void setKorTestEx() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setKorhatar("");
		 assertEquals(0, f.getKorhatar());
	 }
	 
	 @Test
	 public void setHosszTest() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setHossz("0");
		 assertEquals(0, f.getHossz());
	 }
	 
	 @Test(expected = Exception.class)
	 public void setHosszTestEx() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setHossz("");
		 assertEquals("0", f.getHossz());
	 }
	 
	 @Test
	 public void setBoritoTeszt() throws Exception
	 {
		 Film f = new Film("", "", "", "", "", "0", "0","0", "");
		 f.setBorito("Hello");
		 assertEquals("Hello", f.getBorito());
	 }
}
