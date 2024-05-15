package br.ucsal.clinica.repository;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.RiscoOcupacional;

public interface RiscoOcupacionalRepository extends JpaRepository<RiscoOcupacional, Long> {
    Page<RiscoOcupacional> findAll(Pageable pageable);
}
