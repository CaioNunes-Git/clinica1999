package br.ucsal.clinica.repository;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

import br.ucsal.clinica.model.TipoEmpresa;

public interface TipoEmpresaRepository extends JpaRepository<TipoEmpresa, Long>{
    Page<TipoEmpresa> findAll(Pageable pageable);
}
