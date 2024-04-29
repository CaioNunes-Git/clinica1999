package br.ucsal.clinica.service;

import br.ucsal.clinica.model.Medico;
import br.ucsal.clinica.repository.MedicoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;

@Service
public class MedicoService {
    @Autowired
    MedicoRepository medicoRepository;
    public Page<Medico> findAll(Pageable pageable) {
        return medicoRepository.findAll(pageable);
    }
}
