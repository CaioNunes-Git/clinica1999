package br.ucsal.clinica.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.Exame;

public interface ExameRepository extends JpaRepository<Exame, Long> {

}
