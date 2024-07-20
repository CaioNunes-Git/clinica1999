package br.ufba.tomorrow.carro;

public class Carro implements AcoesCarro{
	private String modelo;
	private int velocidade;
	private int aceleracao;
	private int marcha;
	private boolean ligado;

	public Carro(String modelo, int velocidade, int aceleracao, int marcha, boolean ligado) {
		this.modelo = modelo;
		this.velocidade = 0;
		this.aceleracao = 10;
		this.marcha = 1;
		this.ligado = ligado;
	}

	public String getModelo() {
		return modelo;
	}

	public void setModelo(String modelo) {
		this.modelo = modelo;
	}

	public int getVelocidade() {
		return velocidade;
	}

	public void setVelocidade(int velocidade) {
		this.velocidade = velocidade;
	}

	public int getAceleracao() {
		return aceleracao;
	}

	public void setAceleracao(int aceleracao) {
		this.aceleracao = aceleracao;
	}

	public int getMarcha() {
		return marcha;
	}

	public void setMarcha(int marcha) {
		this.marcha = marcha;
	}

	public boolean isLigado() {
		return ligado;
	}

	public void setLigado(boolean ligado) {
		this.ligado = ligado;
	}

	@Override
	public void ligar() {
		if(!ligado){
			ligado = true;
			System.out.println("Ligado o carro do modelo: " + modelo);
		} else {
			System.out.println("O carro do modelo: " + modelo + " já está ligado.");
		}

	}

	@Override
	public void desligar() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void acelerar() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void desacelerar() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void girarVolante() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void marchaAutomatica() {
		// TODO Auto-generated method stub
		
	}

}
