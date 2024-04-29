package br.ucsal.clinica.repository;


import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.Atestado;

public interface AtestadoRepository extends JpaRepository<Atestado, Long> {
    Page<Atestado> findAll(Pageable pageable);
}
