package filmtar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.SwingConstants;

public class FilmGomb extends JButton implements ActionListener {
	private Film film;
	private MainFrame mf;
	public FilmGomb(Film film, MainFrame mf) {
		if(film.getBorito().equals(""))
		{
			this.setIcon(new ImageIcon("nincs.png"));
		}
		else
		{
			this.setIcon(new ImageIcon(film.getBorito()));
		}
		//super(new ImageIcon(film.getBorito()));
		this.setSize(255, 500);
		this.film = film;
		this.mf = mf;
		this.setText(film.getCim());
		this.setVerticalTextPosition(SwingConstants.BOTTOM);
		this.setHorizontalTextPosition(SwingConstants.CENTER);
		this.addActionListener(this);
	}
	@Override
	public void actionPerformed(ActionEvent e) {
		JPanel cards = mf.getCards();
		mf.getAdatPanel().SetData(film);
		mf.getCardLayout().show(mf.getCards(), "FILM");
	}
	
	public Film GetFilm() {
		return this.film;
	}
}