package br.ucsal.clinica.repository;


import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.Empresa;

public interface EmpresaRepository extends JpaRepository<Empresa, Long>{
    Page<Empresa> findAll(Pageable pageable);
}
