package br.ucsal.clinica.repository;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.Medico;

public interface MedicoRepository extends JpaRepository<Medico, Long> {
    Page<Medico> findAll(Pageable pageable);
}
