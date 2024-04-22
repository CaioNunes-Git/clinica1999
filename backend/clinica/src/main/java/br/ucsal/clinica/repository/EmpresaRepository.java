package br.ucsal.clinica.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.Empresa;

public interface EmpresaRepository  extends JpaRepository<Empresa, Long>{

}
