package filmtarTeszt;

import static org.junit.Assert.*;

import javax.swing.JTextField;

import org.junit.BeforeClass;
import org.junit.Test;

import filmtar.Film;
import filmtar.SzerkesztoPanel;

public class SzerkesztoPanelTeszt {
	private static SzerkesztoPanel szp;
	private static Film f;
	
	@BeforeClass
	public static void init() throws Exception {
		szp = new SzerkesztoPanel(null);
		f = new Film("a","a","a","a","a","0","0","0","");
		szp.setFilm(f);
	}
	
	@Test
	public void EditCim() {
		szp.getCimTf().setText("b");
		szp.EditFilm(f);
		assertEquals(0, "b".compareTo(f.getCim()));
	}
	
	@Test
	public void EditEredetiCim() {
		szp.getEredetiCimTf().setText("b");
		szp.EditFilm(f);
		assertEquals(0, "b".compareTo(f.getEredetiCim()));
	}
	
	@Test
	public void EditMufaj() {
		szp.getMufajTf().setText("b");
		szp.EditFilm(f);
		assertEquals(0, "b".compareTo(f.getMufaj()));
	}
	
	@Test
	public void EditLeiras() {
		szp.getLeirasTf().setText("b");
		szp.EditFilm(f);
		assertEquals(0, "b".compareTo(f.getLeiras()));
	}
	
	@Test
	public void EditRendezo() {
		szp.getRendezoTf().setText("b");
		szp.EditFilm(f);
		assertEquals(0, "b".compareTo(f.getRendezo()));
	}
	
	@Test
	public void EditEv() {
		szp.getEvTf().setText("1");
		szp.EditFilm(f);
		assertEquals(0, ((Integer)1).compareTo(f.getEv()));
	}
	
	@Test
	public void EditKorhatar() {
		szp.getKorhatarTf().setText("1");
		szp.EditFilm(f);
		assertEquals(0, ((Integer)1).compareTo(f.getKorhatar()));
	}
	
	@Test
	public void EditHossz() {
		szp.getHosszTf().setText("1");
		szp.EditFilm(f);
		assertEquals(0, ((Integer)1).compareTo(f.getHossz()));
	}
	
	@Test
	public void setFilmTest() {
		//SzerkesztoPanel szp = new SzerkesztoPanel(null);
		Film f = new Film();
		szp.setFilm(f);
		assertEquals(f, szp.getFilm());
	}
	
	

}
