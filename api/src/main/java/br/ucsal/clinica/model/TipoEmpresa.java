package br.ucsal.clinica.model;

import jakarta.persistence.*;
import lombok.*;
import org.springframework.data.relational.core.mapping.Table;

@Entity
@Table("tipo_empresa")
@AllArgsConstructor
@NoArgsConstructor
@Data
public class TipoEmpresa {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;
}
