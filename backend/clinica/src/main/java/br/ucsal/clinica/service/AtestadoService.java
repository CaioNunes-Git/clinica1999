package br.ucsal.clinica.service;

import br.ucsal.clinica.model.Atestado;
import br.ucsal.clinica.model.Empresa;
import br.ucsal.clinica.repository.AtestadoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;

@Service
public class AtestadoService {

    @Autowired
    private AtestadoRepository atestadoRepository;

    public Page<Atestado> findAll(Pageable pageable) {
        return atestadoRepository.findAll(pageable);
    }
}
