package br.ucsal.clinica.repository;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.TipoRisco;

public interface TipoRiscoRepository extends JpaRepository<TipoRisco, Long>{
    Page<TipoRisco> findAll(Pageable pageable);
}
