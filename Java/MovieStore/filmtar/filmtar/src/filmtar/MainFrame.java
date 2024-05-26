package filmtar;

import java.awt.BorderLayout;
import java.awt.CardLayout;
import java.awt.GridLayout;
import java.util.Collections;
import java.util.LinkedList;
import java.awt.event.*;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;

import javax.swing.*;

public class MainFrame extends JFrame
{
	private Filmtar tar;
	private CardLayout cl;
	private JPanel cards;
	private FilmPanel filmPanel;
	private AdatPanel adatPanel;
	private SzerkesztoPanel szerkesztoPanel;
	private HozzaadPanel hozzaadPanel;
	private String filename;
	public CardLayout getCardLayout() {
		return cl;
	}
	
	public FilmPanel getFilmPanel() {
		return filmPanel;
	}
	
	public AdatPanel getAdatPanel() {
		return adatPanel;
	}
	
	public SzerkesztoPanel getSzerkesztoPanel() {
		return szerkesztoPanel;
	}
	
	public HozzaadPanel getHozzaadPanel() {
		return hozzaadPanel;
	}
	
	public JPanel getCards() {
		return cards;
	}
	
	public Filmtar getTar() {
		return tar;
	}
	
		
	public MainFrame(String filename) throws IOException
	{
		this.filename = filename;
		addWindowListener(new WindowAdapter()
		{
		    @Override
		    public void windowClosing(WindowEvent e)
		    {
		    	try
				{
					FileOutputStream fos = new FileOutputStream(filename);
					ObjectOutputStream oos = new ObjectOutputStream(fos);
					for(Film f: tar.getTar())
					{
						oos.writeObject(f);
					}
				}
				catch(Exception ex)
				{
					ex.printStackTrace();
				}
		    	e.getWindow().dispose();
		    }
		});
		tar = new Filmtar();
		try {
			tar.load(this.filename);
		} catch(Exception e) {
			e.printStackTrace();
			try {
				File f = new File(this.filename);
				f.createNewFile();
			}
			catch(Exception ex) {
				throw ex;
			}
		}
		Collections.sort(tar.getTar(),(x,y) -> x.getCim().compareTo(y.getCim()));
		cl = new CardLayout();
		cards = new JPanel(cl);
		filmPanel = new FilmPanel(tar, this);
		adatPanel = new AdatPanel(this, "nincs.png");
		szerkesztoPanel = new SzerkesztoPanel(this);
		hozzaadPanel = new HozzaadPanel(this, tar);
		cards.add(filmPanel, "MAIN");
		cards.add(adatPanel, "FILM");
		cards.add(szerkesztoPanel, "SZERKESZTO");
		cards.add(hozzaadPanel, "HOZZAAD");
		cl.show(cards, "MAIN");
		this.add(cards);
		this.setVisible(true);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.pack();
	}
}