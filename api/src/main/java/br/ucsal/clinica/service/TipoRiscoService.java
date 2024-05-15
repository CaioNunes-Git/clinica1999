package br.ucsal.clinica.service;

import br.ucsal.clinica.model.TipoRisco;
import br.ucsal.clinica.repository.TipoRiscoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;

@Service
public class TipoRiscoService {
    @Autowired
    TipoRiscoRepository tipoRiscoRepository;
    public Page<TipoRisco> findAll(Pageable pageable) {
        return tipoRiscoRepository.findAll(pageable);
    }
}
