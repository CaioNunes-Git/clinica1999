package br.ucsal.clinica.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.Funcionario;

public interface FuncionarioRepository extends JpaRepository<Funcionario, Long> {

}
