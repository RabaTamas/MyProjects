package filmtarTeszt;

import static org.junit.Assert.*;

import java.io.IOException;

import org.junit.BeforeClass;
import org.junit.Test;

import filmtar.MainFrame;

public class MainFrameTeszt {
	private static MainFrame mf;
	
	@BeforeClass
	public static void init() {
		
	}
	
	@Test(expected = Exception.class)
	public void ctorTestEx() throws IOException {
		mf = new MainFrame("");
	}
	
	@Test
	public void getFilmPanelTest() throws Exception {
		mf = new MainFrame("filmteszt.txt");
		assertTrue(mf.getFilmPanel() != null);
	}
	
	@Test
	public void getAdatPanelTest() throws Exception {
		mf = new MainFrame("film.txt");
		assertTrue(mf.getAdatPanel() != null);
	}
	
	@Test
	public void getHozzadPanelTest() throws Exception {
		mf = new MainFrame("film.txt");
		assertTrue(mf.getHozzaadPanel() != null);
	}
	
	@Test
	public void getSzerkeszoPanelTest() throws Exception {
		mf = new MainFrame("film.txt");
		assertTrue(mf.getSzerkesztoPanel() != null);
	}
}
