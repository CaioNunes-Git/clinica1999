package br.ucsal.clinica.service;

import br.ucsal.clinica.model.RiscoOcupacional;
import br.ucsal.clinica.repository.RiscoOcupacionalRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;

@Service
public class RiscoOcupacionalService {
    @Autowired
    RiscoOcupacionalRepository riscoOcupacionalRepository;
    public Page<RiscoOcupacional> findAll(Pageable pageable) {
        return riscoOcupacionalRepository.findAll(pageable);
    }
}
