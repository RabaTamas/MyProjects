package filmtarTeszt;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

import filmtar.*;

public class TarTeszt {
	private Tar<Film> t;
	
	@Before
	public void before() {
		t = new Tar<Film>();
	}
	
	@Test
	public void tarAddTest() {
		t.add(new Film());
		assertEquals(1, t.Length());
	}

	@Test
	public void tarRemoveTest() {
		Film f = new Film();
		t.add(f);
		t.remove(f);
		assertEquals(0, t.Length());
	}
	
	@Test
	public void tarRemoveAllTest() {
		Film f = new Film();
		t.add(f);
		t.removeAll();
		assertEquals(0, t.Length());
	}
	
	@Test
	public void tarLengthTest() {
		assertEquals(0, t.Length());
	}
	
	@Test
	public void tarSortTest() throws Exception
	{
		Film f1 = new Film();
		f1.setCim("b");
		t.add(f1);
		Film f2 = new Film();
		f2.setCim("a");
		t.add(f2);
		Film f3 = new Film();
		f3.setCim("c");
		t.add(f3);
		t.sort((x,y) -> (x.getCim().compareTo(y.getCim())));
		assertTrue(isSorted(t));

	}
	
	private boolean isSorted(Tar<Film> t) {
		if (t.Length() <= 1) {
	        return true;
	    }
		
		var iter = t.iterator();
	    Film current, previous = iter.next();
	    while (iter.hasNext()) {
	        current = iter.next();
	        if (previous.getCim().compareTo(current.getCim()) > 0) {
	            return false;
	        }
	        previous = current;
	    }
	    return true;
	}

}
