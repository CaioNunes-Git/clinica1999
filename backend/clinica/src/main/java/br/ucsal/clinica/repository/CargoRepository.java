package br.ucsal.clinica.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.Cargo;

public interface CargoRepository extends JpaRepository<Cargo, Long> {

}
