package filmtarTeszt;

import static org.junit.Assert.*;

import java.awt.event.ActionEvent;

import javax.swing.JButton;

import org.junit.BeforeClass;
import org.junit.Test;

import filmtar.Film;
import filmtar.MainFrame;

public class HozzaadPanelTeszt {
	private static MainFrame mf; 
	private static JButton b;
	@BeforeClass
	public static void init()
	{
		mf = null;
		try {
			mf = new MainFrame("filmekteszt.txt");
		}
		catch (Exception e) {
			e.printStackTrace();
		}
		mf.getHozzaadPanel().getCimTf().setText("a");
		mf.getHozzaadPanel().getEredetiCimTf().setText("a");
		mf.getHozzaadPanel().getRendezoTf().setText("a");
		mf.getHozzaadPanel().getLeirasTf().setText("a");
		mf.getHozzaadPanel().getMufajTf().setText("a");
		mf.getHozzaadPanel().getEvTf().setText("0");
		mf.getHozzaadPanel().getKorhatarTf().setText("0");
		mf.getHozzaadPanel().getHosszTf().setText("0");
		mf.getHozzaadPanel().getBoritoTf().setText("");
		//mf.getHozzaadPanel().EditFilm(f);
		b = new JButton();
	}
	@Test
	public void testMENTES() {
		
		int hossz = mf.getTar().Length();
		ActionEvent ae = new ActionEvent(b, 0, "MENTES");
		mf.getHozzaadPanel().actionPerformed(ae);
		
		assertEquals(hossz+1, mf.getTar().Length());
	}
	
	@Test
	public void testMEGSE() {
		
		int hossz = mf.getTar().Length();
		ActionEvent ae = new ActionEvent(b, 0, "MEGSE");
		mf.getHozzaadPanel().actionPerformed(ae);
		
		assertEquals(hossz, mf.getTar().Length());
	}
	
	@Test
	public void testROSSZMENTES() {
		
		int hossz = mf.getTar().Length();
		mf.getHozzaadPanel().getCimTf().setText("");;
		ActionEvent ae = new ActionEvent(b, 0, "MENTES");
		mf.getHozzaadPanel().actionPerformed(ae);
		
		assertEquals(hossz, mf.getTar().Length());
	}

}
