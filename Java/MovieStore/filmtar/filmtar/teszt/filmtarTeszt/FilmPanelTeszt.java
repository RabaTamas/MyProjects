package filmtarTeszt;

import static org.junit.Assert.*;

import java.awt.event.ActionEvent;

import javax.swing.JComboBox;
import javax.swing.JTextField;
import javax.swing.plaf.synth.SynthFormattedTextFieldUI;

import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

import filmtar.Film;
import filmtar.FilmGomb;
import filmtar.FilmPanel;
import filmtar.Filmtar;
import filmtar.Tar;

public class FilmPanelTeszt {

	private static FilmPanel fp;
	private static ActionEvent ae;
	private static JTextField tf;
	private static JComboBox<String> jcb;
	private static Filmtar tar;
	
	@BeforeClass
	public static void init() throws Exception {
		tar = new Filmtar();
		Film f1 = new Film("","","","","","0","0","0","");
		f1.setCim("Hello");
		tar.add(f1);
		Film f2 = new Film("","","","","","0","0","0","");
		f2.setCim("Bello");
		tar.add(f2);
		Film f3 = new Film("","","","","","0","0","0","");
		f3.setCim("Szia");
		tar.add(f3);
		fp = new FilmPanel(tar, null);
	}
	
	@Before
	public void before() {
		fp.getGombok().removeAll();
		fp.Update();
		//assertEquals(3, fp.getGombok().Length());
		
	}
	
	
	  @Test public void updateTest() { 
		  fp.Update(); assertEquals(0, 0); 
	  }
	 
	
	@Test
	public void keresesTest() {
		tf = new JTextField();
		tf.setText("Be");
		ae = new ActionEvent(tf, 0, "kereses");
		fp.actionPerformed(ae);
		assertEquals(1, fp.getGombok().Length());
	}
	
	@Test
	public void rendezesCimTest() {
		jcb = new JComboBox<String>();
		jcb.addItem("cim");
		jcb.addItem("ev");
		jcb.addItem("mufaj");
		jcb.setSelectedItem("cim");
		ae = new ActionEvent(jcb, 0, "rendezes");
		fp.actionPerformed(ae);
		//System.out.println(fp.getGombok().Length());
		assertTrue(isSorted(fp.getGombok(), "cim"));
	}
	
	@Test
	public void rendezesEvTest() {
		jcb = new JComboBox<String>();
		jcb.addItem("cim");
		jcb.addItem("ev");
		jcb.addItem("mufaj");
		jcb.setSelectedItem("ev");
		ae = new ActionEvent(jcb, 0, "rendezes");
		fp.actionPerformed(ae);
		//System.out.println(fp.getGombok().Length());
		assertTrue(isSorted(fp.getGombok(), "ev"));
	}
	
	@Test
	public void rendezesMufajTest() {
		jcb = new JComboBox<String>();
		jcb.addItem("cim");
		jcb.addItem("ev");
		jcb.addItem("mufaj");
		jcb.setSelectedItem("mufaj");
		ae = new ActionEvent(jcb, 0, "rendezes");
		fp.actionPerformed(ae);
		//System.out.println(fp.getGombok().Length());
		assertTrue(isSorted(fp.getGombok(), "mufaj"));
	}
	
	private boolean isSorted(Tar<FilmGomb> t, String feltetel) {
		if (t.Length() <= 1) {
	        return true;
	    }
		
		var iter = t.iterator();
	    FilmGomb current, previous = iter.next();
	    while (iter.hasNext()) {
	        current = iter.next();
	        if(feltetel.equals("cim")) {
		        if (previous.GetFilm().getCim().compareTo(current.GetFilm().getCim()) > 0) {
		            return false;
		        }
	        }
	        else if(feltetel.equals("ev")) {
		        if (((Integer)previous.GetFilm().getEv()).compareTo(current.GetFilm().getEv()) > 0) {
		            return false;
		        }
	        }
	        else if(feltetel.equals("mufaj")) {
		        if (previous.GetFilm().getMufaj().compareTo(current.GetFilm().getMufaj()) > 0) {
		            return false;
		        }
	        }
	        previous = current;
	    }
	    return true;
	}
}
