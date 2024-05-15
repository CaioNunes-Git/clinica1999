package br.ucsal.clinica.service;

import br.ucsal.clinica.model.TipoEmpresa;
import br.ucsal.clinica.repository.TipoEmpresaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;

@Service
public class TipoEmpresaService {
    @Autowired
    TipoEmpresaRepository tipoEmpresaRepository;
    public Page<TipoEmpresa> findAll(Pageable pageable) {
        return tipoEmpresaRepository.findAll(pageable);
    }
}
