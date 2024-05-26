package filmtar;

import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public abstract class BaseSzerkesztoPanel extends JPanel implements ActionListener{
	protected JTextField cim_tf, ecim_tf, mufaj_tf, leiras_tf, rendezo_tf, ev_tf, hossz_tf, korhatar_tf, borito_tf;
	protected MainFrame mf;
	
	private class FileChooserActionListener implements ActionListener {
		private JTextField borito;
		
		public FileChooserActionListener(JTextField borito) {
			this.borito = borito;
		}
		
		@Override
		public void actionPerformed(ActionEvent e) {
			JFileChooser fileChooser = new JFileChooser(System.getProperty("user.dir"));
			int result = fileChooser.showOpenDialog(null);
			if (result == JFileChooser.APPROVE_OPTION) {
				this.borito.setText(fileChooser.getSelectedFile().getAbsolutePath());
			}	
		}
		
	}
	
	public BaseSzerkesztoPanel(MainFrame mf) {
		this.mf = mf;
		this.setLayout(new GridLayout(10,2));
		JLabel cim = new JLabel("Cim:");
		JLabel ecim = new JLabel("Eredeti cim:");
		JLabel mufaj = new JLabel("Mufaj:");
		JLabel leiras = new JLabel("Leiras:");
		JLabel rendezo = new JLabel("Rendezo:");
		JLabel ev = new JLabel("Ev:");
		JLabel hossz = new JLabel("Hossz:");
		JLabel korhatar = new JLabel("Korhatar:");
		JLabel borito = new JLabel("Borito:");
		cim_tf = new JTextField();
		ecim_tf = new JTextField();
		mufaj_tf = new JTextField();
		leiras_tf = new JTextField();
		rendezo_tf = new JTextField();
		ev_tf = new JTextField();
		hossz_tf = new JTextField();
		korhatar_tf = new JTextField();
		this.add(cim);
		this.add(cim_tf);
		this.add(ecim);
		this.add(ecim_tf);
		this.add(mufaj);
		this.add(mufaj_tf);
		this.add(leiras);
		this.add(leiras_tf);
		this.add(rendezo);
		this.add(rendezo_tf);
		this.add(ev);
		this.add(ev_tf);
		this.add(hossz);
		this.add(hossz_tf);
		this.add(korhatar);
		this.add(korhatar_tf);
		this.add(borito);
		borito_tf = new JTextField(20);
		JButton bopen = new JButton("Kereses");
		bopen.addActionListener(new FileChooserActionListener(borito_tf));
		JPanel boritopanel = new JPanel();
		boritopanel.add(borito_tf);
		boritopanel.add(bopen);
		this.add(boritopanel);
		JButton bback = new JButton("Megse");
		bback.addActionListener(this);
		bback.setActionCommand("MEGSE");
		JButton bsave = new JButton("Mentes");
		bsave.addActionListener(this);
		bsave.setActionCommand("MENTES");
		this.add(bsave);
		this.add(bback);
	}
	
	public JTextField getCimTf() {
		return cim_tf;
	}
	
	public JTextField getEredetiCimTf() {
		return ecim_tf;
	}
	
	public JTextField getMufajTf() {
		return mufaj_tf;
	}
	
	public JTextField getLeirasTf() {
		return leiras_tf;
	}
	
	public JTextField getRendezoTf() {
		return rendezo_tf;
	}
	
	public JTextField getEvTf() {
		return ev_tf;
	}
	
	public JTextField getKorhatarTf() {
		return korhatar_tf;
	}
	
	public JTextField getHosszTf() {
		return hossz_tf;
	}
	
	public JTextField getBoritoTf() {
		return borito_tf;
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
	}

}