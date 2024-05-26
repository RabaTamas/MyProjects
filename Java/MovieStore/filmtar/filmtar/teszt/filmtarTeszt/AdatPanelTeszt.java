package filmtarTeszt;

import static org.junit.Assert.*;

import org.junit.BeforeClass;
import org.junit.Test;

import filmtar.AdatPanel;
import filmtar.Film;

public class AdatPanelTeszt {
	private static AdatPanel ap;
	private static Film f;
	
	@BeforeClass
	public static void init() throws Exception {
		ap = new AdatPanel(null, "forrest.jpg");
		f = new Film("a", "a", "a", "a", "a", "0", "0", "0", "");
	}
	@Test
	public void setDataTest() {
		ap.SetData(f);
		assertTrue(
				ap.getCimJl().getText().equals("a") &&
				ap.getErdetiCimJl().getText().equals("a") &&
				ap.getLeirasJl().getText().equals("a") &&
				ap.getRendezoJl().getText().equals("a") &&
				ap.getMufajJl().getText().equals("a") &&
				ap.getEvJl().getText().equals("0") &&
				ap.getHosszJl().getText().equals("0") &&
				ap.getKorhatarJl().getText().equals("0")
			);
	}
	
	@Test(expected=Exception.class)
	public void setDataTestEx() {
		ap.setDefaultImage("");
		ap.SetData(f);
		assertTrue(
				ap.getCimJl().getText().equals("a") &&
				ap.getErdetiCimJl().getText().equals("a") &&
				ap.getLeirasJl().getText().equals("a") &&
				ap.getRendezoJl().getText().equals("a") &&
				ap.getMufajJl().getText().equals("a") &&
				ap.getEvJl().getText().equals("0") &&
				ap.getHosszJl().getText().equals("0") &&
				ap.getKorhatarJl().getText().equals("0")
			);
	}

}
