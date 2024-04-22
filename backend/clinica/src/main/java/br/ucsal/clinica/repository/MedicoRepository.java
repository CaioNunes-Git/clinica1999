package br.ucsal.clinica.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.Medico;

public interface MedicoRepository extends JpaRepository<Medico, Long> {

}
