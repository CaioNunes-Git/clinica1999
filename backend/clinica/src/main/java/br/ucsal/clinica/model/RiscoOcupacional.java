package br.ucsal.clinica.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.relational.core.mapping.Table;

@Entity
@Table("risco_ocupacional")
@AllArgsConstructor
@NoArgsConstructor
@Data
public class RiscoOcupacional {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;

    @Column(name = "tipo_risco_id")
    private TipoRisco tipoRisco;
}
