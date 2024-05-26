package filmtar;

import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;

public class HozzaadPanel extends SzerkesztoPanel implements ActionListener {
	private Filmtar tar;
	@Override
	public void actionPerformed(ActionEvent e) {
		if(e.getActionCommand()== "MEGSE")
			mf.getCardLayout().show(mf.getCards(), "MAIN");
		if(e.getActionCommand()== "MENTES")
		{
			Film f = new Film();
			if(EditFilm(f) == true)
				return;
			this.tar.add(f);
			this.mf.getFilmPanel().Update();
			mf.getCardLayout().show(mf.getCards(), "MAIN");
		}
		
	}
	public HozzaadPanel(MainFrame mf, Filmtar tar)
	{
		super(mf);
		this.tar = tar;
	}

}