package filmtar;

import java.util.Comparator;
import java.util.Iterator;
import java.util.LinkedList;


public class Tar<T> implements Iterable<T> {
	protected LinkedList<T> tar = new LinkedList<>();
	
	public void add(T t)
	{
		tar.add(t);
	}
	
	public void remove(T t)
	{
		tar.remove(t);
	}
	
	public void removeAll() {
		tar.removeAll(tar);
	}
	
	public LinkedList<T> getTar()
	{
		return tar;
	}
	
	public int Length() {
		return tar.size();
	}
	
	@Override
	public Iterator<T> iterator() {
		return this.tar.iterator();
	}
	
	public void sort(Comparator<T> c) {		
		tar.sort(c);
	}	
}
